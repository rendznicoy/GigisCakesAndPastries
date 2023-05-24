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

namespace GigisCakesAndPastries
{
    public class Database
    {
        private static string downloadPath = AppDomain.CurrentDomain.BaseDirectory;
        private static string directoryID = "1n0InfCLZg7nLXlSjw7yWkq0-GBwMCu6M";

        private static string CustomerListGoogleDriveFileID = "1kSIEjrhILRQvcoWDAhTJ7g1AGhXHWaT7";
        private static string AdminListGoogleDriveFileID = "1VAmLRIDV_HNDj6AMsU8EaBD49GolqtLm";

        private static string CustomerListFileName = "CustomerRecords.gcp";
        private static string AdminListFileName = "AdminRecords.gcp";

        public static string keyword = "gigiscakesandpastries246";

        public static List<Admin> Admins = new List<Admin>();
        public static List<Customer> Customers = new List<Customer>();

        public static List<User> UserMasterlist()
        {
            List<User> UserMasterlist = new List<User>();
            UserMasterlist.AddRange(Admins);
            UserMasterlist.AddRange(Customers);

            return UserMasterlist;
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

            if (adminList.Files.Count == 0)
                throw new FileNotFoundException("Error: Online database does not contain the doctor records masterlist");

            DownloadAdminList();
            DeserializeAdmin();

        }

        #endregion
    }
}
