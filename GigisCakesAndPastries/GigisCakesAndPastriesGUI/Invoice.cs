using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace GigisCakesAndPastriesGUI
{
    public partial class Invoice : Form
    {
        public string lblID;
        public string cstmrName;
        public string cstmrPNum;
        public string cstmrAdd;
        public string productName;
        public string productSize;
        public string orderType;
        public string paymentMethod;
        public string productQty;
        public int productCnt;
        public double productTotal;
        public DateTime orderDate;
        public string orderStatus;
        public Form parentForm;
        public Invoice(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void backBtn2_Click(object sender, EventArgs e)
        {

        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            orderID.Text = lblID;
            string ordDate = orderDate.ToString("MMMM d, yyyy");
            invDate.Text = ordDate;
            cstmrDetails.Text = cstmrName + "\n" + cstmrPNum + "\n" + cstmrAdd;
            prdLbl.Text = productQty + " " + productSize + " " + productName;
            ordTypeLbl.Text = orderType;
            payLbl.Text = paymentMethod;
            string total = productTotal.ToString();
            prcLbl.Text = total;
        }

        public static void CaptureFormToImage(Form form)
        {
            using (SaveFileDialog sFD = new SaveFileDialog())
            {
                sFD.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                if (sFD.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = new Bitmap(form.Width, form.Height);

                    form.DrawToBitmap(bitmap, new Rectangle(0, 0, form.Width, form.Height));

                    bitmap.Save(sFD.FileName);
                }
            }

        }
        private void stepTwoNextBtn_Click(object sender, EventArgs e)
        {
            CaptureFormToImage(this);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cstmrDetails_TextChanged(object sender, EventArgs e)
        {
            cstmrDetails.MaximumSize = new Size(ClientSize.Width - cstmrDetails.Left, 0);
        }
    }
}
