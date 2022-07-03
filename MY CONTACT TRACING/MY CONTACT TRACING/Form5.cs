using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace MY_CONTACT_TRACING
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void GQr_Click(object sender, EventArgs e)
        {
            string QRData = fnTB.Text + aTB.Text + sTB.Text + pnTB.Text + haTB.Text + bTB.Text + cTB.Text + vTB.Text + erTB.Text;
            string QRFileName = QRFileNameTB.Text;

            BarcodeWriter barcodeW = new BarcodeWriter();
            barcodeW.Format = BarcodeFormat.QR_CODE;
            barcodeW.Write(QRData).Save(@"C:\Users\kylene shane varona\Desktop\MY ASSIGN 3\QR\" + QRFileName + " .jpg");
            PBoxImage.Image = Image.FromFile(@"C:\Users\kylene shane varona\Desktop\MY ASSIGN 3\QR\" + QRFileName + " .jpg");

            MessageBox.Show("Done");
        }

        private void EXITMenu_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void COMPANYMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Kylene Shane M. Varona from BSCOE 1-5", "BASIC INFO");
        }
    }
}
