using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Drive.v3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Download;
using GigisCakesAndPastries.Properties;
//using static System.Net.WebRequestMethods;

namespace GigisCakesAndPastries
{
    public class Database
    {
        private static string downloadPath = AppDomain.CurrentDomain.BaseDirectory;
        private static string directoryID = "1n0InfCLZg7nLXlSjw7yWkq0-GBwMCu6M";

        private static string CustomerListGoogleDriveFileID = "1kSIEjrhILRQvcoWDAhTJ7g1AGhXHWaT7";
        private static string AdminListGoogleDriveFileID = "1VAmLRIDV_HNDj6AMsU8EaBD49GolqtLm";
        private static string CakeListGoogleDriveFileID = "1bxpRyxDb2CGZkz4t6LApuCTchxNb0nq3";
        private static string PastryListGoogleDriveFileID = "1-eafkJra7QZ5RlpCWqXfispY86HQYVik";
        private static string IngredientListGoogleDriveFileID = "1Mlw_kNaecz-17RgP-5pOnc4l-xVSYKdm";

        private static string CustomerListFileName = "CustomerRecords.gcp";
        private static string AdminListFileName = "AdminRecords.gcp";
        private static string CakeListFileName = "CakeRecords.gcp";
        private static string PastryListFileName = "PastryRecords.gcp";
        private static string IngredientListFileName = "IngredientRecords.gcp";

        public static string keyword = "gigiscakesandpastries246";

        public static List<Admin> Admins = new List<Admin>();
        public static List<Customer> Customers = new List<Customer>();
        public static List<Cakes> Cakes = new List<Cakes>();
        public static List<Pastries> Pastry = new List<Pastries>();
        public static List<Ingredients> Ingredient = new List<Ingredients>();

        public static List<User> UserMasterlist()
        {
            List<User> UserMasterlist = new List<User>();
            UserMasterlist.AddRange(Admins);
            UserMasterlist.AddRange(Customers);

            return UserMasterlist;
        }

        public static List<Products> ProductMasterlist()
        {
            List<Products> ProductsMasterlist = new List<Products>();
            ProductsMasterlist.AddRange(Cakes);
            ProductsMasterlist.AddRange(Pastry);

            return ProductsMasterlist;
        }
        public static List<Ingredients> IngredientList()
        {
            List<Ingredients> IngredientsMasterlist = new List<Ingredients>();
            IngredientsMasterlist.AddRange(Ingredient);

            return IngredientsMasterlist;
        }
        

        #region Create File To Google Drive
        public static void CreateFileToGoogleDrive()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.GigisCakesAndPastriesServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = AdminListFileName,
                    MimeType = "text/plain",
                    Description = $"Modified at {DateTime.Now} ",
                    Parents = new List<string>() { directoryID }
                };

                using (var stream = new FileStream(AdminListFileName, FileMode.OpenOrCreate))
                {
                    var request = service.Files.Create(fileMetadata, stream, "text/plain");
                    request.Fields = "id";
                    request.Upload();

                    Console.WriteLine(request.ResponseBody.Id);
                };
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }
        #endregion

        #region  List Serialization and Deserialization

        public static void SerializeAdmin()
        {
            string contents = JsonConvert.SerializeObject(Admins);
            File.WriteAllText(AdminListFileName, contents);
        }

        public static void DeserializeAdmin()
        {
            string contents = File.ReadAllText(Path.Combine(downloadPath, AdminListFileName));
            Admins = JsonConvert.DeserializeObject<List<Admin>>(contents);
        }

        public static void SerializeCustomers()
        {
            string contents = JsonConvert.SerializeObject(Customers);
            File.WriteAllText(CustomerListFileName, contents);
        }

        public static void DeserializeCustomers()
        {
            string contents = File.ReadAllText(Path.Combine(downloadPath, CustomerListFileName));
            Customers = JsonConvert.DeserializeObject<List<Customer>>(contents);
        }
        public static void SerializeCakes()
        {
            string contents = JsonConvert.SerializeObject(Cakes);
            File.WriteAllText(CakeListFileName, contents);
        }

        public static void DeserializeCakes()
        {
            string contents = File.ReadAllText(Path.Combine(downloadPath, CakeListFileName));
            Cakes = JsonConvert.DeserializeObject<List<Cakes>>(contents);
        }
        public static void SerializePastry()
        {
            string contents = JsonConvert.SerializeObject(Pastry);
            File.WriteAllText(PastryListFileName, contents);
        }

        public static void DeserializePastry()
        {
            string contents = File.ReadAllText(Path.Combine(downloadPath, PastryListFileName));
            Pastry = JsonConvert.DeserializeObject<List<Pastries>>(contents);
        }
        public static void SerializeIngredient()
        {
            string contents = JsonConvert.SerializeObject(Ingredient);
            File.WriteAllText(IngredientListFileName, contents);
        }

        public static void DeserializeIngredient()
        {
            string contents = File.ReadAllText(Path.Combine(downloadPath, IngredientListFileName));
            Ingredient = JsonConvert.DeserializeObject<List<Ingredients>>(contents);
        }
        #endregion

        #region List Upload and Download

        public static void UploadAdminList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.GigisCakesAndPastriesServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v2.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var fileMetadata = new Google.Apis.Drive.v2.Data.File()
                {
                    Title = AdminListFileName,
                    MimeType = "text/plain",
                    Description = $"Modified at {DateTime.Now} ",
                    Parents = new List<Google.Apis.Drive.v2.Data.ParentReference>() { new Google.Apis.Drive.v2.Data.ParentReference { Id = directoryID } }
                };

                byte[] bytes = System.IO.File.ReadAllBytes(AdminListFileName);
                MemoryStream stream = new MemoryStream(bytes);

                var request = service.Files.Update(fileMetadata, AdminListGoogleDriveFileID, stream, "text/plain");
                request.Upload();

                Console.WriteLine(AdminListGoogleDriveFileID.Equals(request.ResponseBody.Id) ? "Success" : throw new FileNotFoundException());
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public static void DownloadAdminList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.GigisCakesAndPastriesServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v3.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var request = service.Files.Get(AdminListGoogleDriveFileID);
                request.SupportsAllDrives = true;
                request.MediaDownloader.ProgressChanged +=
                    progress =>
                    {
                        switch (progress.Status)
                        {
                            case DownloadStatus.Downloading:
                                {
                                    Console.WriteLine(progress.BytesDownloaded);
                                    break;
                                }
                            case DownloadStatus.Completed:
                                {
                                    Console.WriteLine("Download complete.");
                                    break;
                                }
                            case DownloadStatus.Failed:
                                {
                                    Console.WriteLine("Download failed.");
                                    break;
                                }
                        }
                    };

                var stream = new MemoryStream();
                request.Download(stream);

                using (var fileStream = new FileStream(Path.Combine(downloadPath, AdminListFileName), FileMode.Create, FileAccess.Write))
                {
                    stream.WriteTo(fileStream);
                }
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public static void UploadCustomerList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.GigisCakesAndPastriesServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v2.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var fileMetadata = new Google.Apis.Drive.v2.Data.File()
                {
                    Title = CustomerListFileName,
                    MimeType = "text/plain",
                    Description = $"Modified at {DateTime.Now} ",
                    Parents = new List<Google.Apis.Drive.v2.Data.ParentReference>() { new Google.Apis.Drive.v2.Data.ParentReference { Id = directoryID } }
                };

                byte[] bytes = System.IO.File.ReadAllBytes(CustomerListFileName);
                MemoryStream stream = new MemoryStream(bytes);

                var request = service.Files.Update(fileMetadata, CustomerListGoogleDriveFileID, stream, "text/plain");
                request.Upload();

                Console.WriteLine(CustomerListGoogleDriveFileID.Equals(request.ResponseBody.Id) ? "Success" : throw new FileNotFoundException());
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public static void DownloadCustomerList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.GigisCakesAndPastriesServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v3.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var request = service.Files.Get(CustomerListGoogleDriveFileID);
                request.SupportsAllDrives = true;
                request.MediaDownloader.ProgressChanged +=
                    progress =>
                    {
                        switch (progress.Status)
                        {
                            case DownloadStatus.Downloading:
                                {
                                    Console.WriteLine(progress.BytesDownloaded);
                                    break;
                                }
                            case DownloadStatus.Completed:
                                {
                                    Console.WriteLine("Download complete.");
                                    break;
                                }
                            case DownloadStatus.Failed:
                                {
                                    Console.WriteLine("Download failed.");
                                    break;
                                }
                        }
                    };

                var stream = new MemoryStream();
                request.Download(stream);

                using (var fileStream = new FileStream(Path.Combine(downloadPath, CustomerListFileName), FileMode.Create, FileAccess.Write))
                {
                    stream.WriteTo(fileStream);
                }
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }
        public static void UploadCakeList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.GigisCakesAndPastriesServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v2.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var fileMetadata = new Google.Apis.Drive.v2.Data.File()
                {
                    Title = CakeListFileName,
                    MimeType = "text/plain",
                    Description = $"Modified at {DateTime.Now} ",
                    Parents = new List<Google.Apis.Drive.v2.Data.ParentReference>() { new Google.Apis.Drive.v2.Data.ParentReference { Id = directoryID } }
                };

                byte[] bytes = System.IO.File.ReadAllBytes(CakeListFileName);
                MemoryStream stream = new MemoryStream(bytes);

                var request = service.Files.Update(fileMetadata, CakeListGoogleDriveFileID, stream, "text/plain");
                request.Upload();

                Console.WriteLine(CakeListGoogleDriveFileID.Equals(request.ResponseBody.Id) ? "Success" : throw new FileNotFoundException());
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public static void DownloadCakeList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.GigisCakesAndPastriesServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v3.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var request = service.Files.Get(CakeListGoogleDriveFileID);
                request.SupportsAllDrives = true;
                request.MediaDownloader.ProgressChanged +=
                    progress =>
                    {
                        switch (progress.Status)
                        {
                            case DownloadStatus.Downloading:
                                {
                                    Console.WriteLine(progress.BytesDownloaded);
                                    break;
                                }
                            case DownloadStatus.Completed:
                                {
                                    Console.WriteLine("Download complete.");
                                    break;
                                }
                            case DownloadStatus.Failed:
                                {
                                    Console.WriteLine("Download failed.");
                                    break;
                                }
                        }
                    };

                var stream = new MemoryStream();
                request.Download(stream);

                using (var fileStream = new FileStream(Path.Combine(downloadPath, CakeListFileName), FileMode.Create, FileAccess.Write))
                {
                    stream.WriteTo(fileStream);
                }
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }
        public static void UploadPastryList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.GigisCakesAndPastriesServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v2.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var fileMetadata = new Google.Apis.Drive.v2.Data.File()
                {
                    Title = PastryListFileName,
                    MimeType = "text/plain",
                    Description = $"Modified at {DateTime.Now} ",
                    Parents = new List<Google.Apis.Drive.v2.Data.ParentReference>() { new Google.Apis.Drive.v2.Data.ParentReference { Id = directoryID } }
                };

                byte[] bytes = System.IO.File.ReadAllBytes(PastryListFileName);
                MemoryStream stream = new MemoryStream(bytes);

                var request = service.Files.Update(fileMetadata, PastryListGoogleDriveFileID, stream, "text/plain");
                request.Upload();

                Console.WriteLine(PastryListGoogleDriveFileID.Equals(request.ResponseBody.Id) ? "Success" : throw new FileNotFoundException());
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public static void DownloadPastryList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.GigisCakesAndPastriesServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v3.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var request = service.Files.Get(PastryListGoogleDriveFileID);
                request.SupportsAllDrives = true;
                request.MediaDownloader.ProgressChanged +=
                    progress =>
                    {
                        switch (progress.Status)
                        {
                            case DownloadStatus.Downloading:
                                {
                                    Console.WriteLine(progress.BytesDownloaded);
                                    break;
                                }
                            case DownloadStatus.Completed:
                                {
                                    Console.WriteLine("Download complete.");
                                    break;
                                }
                            case DownloadStatus.Failed:
                                {
                                    Console.WriteLine("Download failed.");
                                    break;
                                }
                        }
                    };

                var stream = new MemoryStream();
                request.Download(stream);

                using (var fileStream = new FileStream(Path.Combine(downloadPath, PastryListFileName), FileMode.Create, FileAccess.Write))
                {
                    stream.WriteTo(fileStream);
                }
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }
        public static void UploadIngredientList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.GigisCakesAndPastriesServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v2.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var fileMetadata = new Google.Apis.Drive.v2.Data.File()
                {
                    Title = IngredientListFileName,
                    MimeType = "text/plain",
                    Description = $"Modified at {DateTime.Now} ",
                    Parents = new List<Google.Apis.Drive.v2.Data.ParentReference>() { new Google.Apis.Drive.v2.Data.ParentReference { Id = directoryID } }
                };

                byte[] bytes = System.IO.File.ReadAllBytes(IngredientListFileName);
                MemoryStream stream = new MemoryStream(bytes);

                var request = service.Files.Update(fileMetadata, IngredientListGoogleDriveFileID, stream, "text/plain");
                request.Upload();

                Console.WriteLine(IngredientListGoogleDriveFileID.Equals(request.ResponseBody.Id) ? "Success" : throw new FileNotFoundException());
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }

        public static void DownloadIngredientList()
        {
            try
            {
                var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.GigisCakesAndPastriesServiceKey)).CreateScoped(DriveService.Scope.Drive);

                var service = new Google.Apis.Drive.v3.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Snippets"
                });

                var request = service.Files.Get(IngredientListGoogleDriveFileID);
                request.SupportsAllDrives = true;
                request.MediaDownloader.ProgressChanged +=
                    progress =>
                    {
                        switch (progress.Status)
                        {
                            case DownloadStatus.Downloading:
                                {
                                    Console.WriteLine(progress.BytesDownloaded);
                                    break;
                                }
                            case DownloadStatus.Completed:
                                {
                                    Console.WriteLine("Download complete.");
                                    break;
                                }
                            case DownloadStatus.Failed:
                                {
                                    Console.WriteLine("Download failed.");
                                    break;
                                }
                        }
                    };

                var stream = new MemoryStream();
                request.Download(stream);

                using (var fileStream = new FileStream(Path.Combine(downloadPath, IngredientListFileName), FileMode.Create, FileAccess.Write))
                {
                    stream.WriteTo(fileStream);
                }
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    Console.WriteLine("Credential not found");
                }
                else if (ex is FileNotFoundException)
                {
                    Console.WriteLine("File not found");
                }
                else
                {
                    throw;
                }
            }
        }

        #endregion

        #region Data Encryption and Decryption

        private static string encryptDecrypt(string data)
        {
            string result = "";

            for(int i = 0; i <data.Length; i++) 
            {
                result += (char)(data[i] ^ Database.keyword[i % Database.keyword.Length]);
            }

            return result;
        }

        #endregion

        #region Database Initialization

        public static void InitializeDatabase()
        {
            var credential = GoogleCredential.FromJson(Encoding.UTF8.GetString(Resources.GigisCakesAndPastriesServiceKey)).CreateScoped(DriveService.Scope.Drive);

            var service = new Google.Apis.Drive.v3.DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Drive API Snippets"
            });

            var adminListQuery = service.Files.List();
            adminListQuery.Q = $"name = '{AdminListFileName}' and '{directoryID}' in parents";
            var adminList = adminListQuery.Execute();

            var customerListQuery = service.Files.List();
            customerListQuery.Q = $"name = '{CustomerListFileName}' and '{directoryID}' in parents";
            var customerList = customerListQuery.Execute();

            var cakeListQuery = service.Files.List();
            cakeListQuery.Q = $"name = '{CakeListFileName}' and '{directoryID}' in parents";
            var cakeList = cakeListQuery.Execute();

            var pastryListQuery = service.Files.List();
            pastryListQuery.Q = $"name = '{PastryListFileName}' and '{directoryID}' in parents";
            var pastryList = pastryListQuery.Execute();

            var ingredientListQuery = service.Files.List();
            ingredientListQuery.Q = $"name = '{IngredientListFileName}' and '{directoryID}' in parents";
            var ingredientList = ingredientListQuery.Execute();

            if (adminList.Files.Count == 0)
                throw new FileNotFoundException("Error: Online database does not contain the admin records masterlist");

            if (customerList.Files.Count == 0)
                throw new FileNotFoundException("Error: Online database does not contain the customer records masterlist");

            if (cakeList.Files.Count == 0)
                throw new FileNotFoundException("Error: Online database does not contain the customer records masterlist");

            if (pastryList.Files.Count == 0)
                throw new FileNotFoundException("Error: Online database does not contain the customer records masterlist");

            if (ingredientList.Files.Count == 0)
                throw new FileNotFoundException("Error: Online database does not contain the customer records masterlist");

            DownloadAdminList();
            DeserializeAdmin();

            DownloadCustomerList();
            DeserializeCustomers();

            DownloadCakeList();
            DeserializeCakes();

            DownloadPastryList();
            DeserializePastry();

            DownloadIngredientList();
            DeserializeIngredient();
        }
        #endregion
    }
}
