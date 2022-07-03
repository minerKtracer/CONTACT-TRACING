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
            string QRData = fnTB1.Text + "\n" + aTB2.Text + "\n" + sTB3.Text + "\n" + pnTB4.Text + "\n" + haTB5.Text + "\n" + bTB6.Text + "\n" + cTB7.Text + "\n" + vTB8.Text + "\n" + erTB9.Text;
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

        private void RTbtn_Click(object sender, EventArgs e)
        {
            if (fnTB1.Text != string.Empty || aTB2.Text != string.Empty || sTB3.Text != string.Empty || pnTB4.Text != string.Empty || haTB5.Text != string.Empty || bTB6.Text != string.Empty || cTB7.Text != string.Empty || vTB8.Text != string.Empty || erTB9.Text != string.Empty)
            {
                fnTB1.Text = "";
                aTB2.Text = "";
                sTB3.Text = "";
                pnTB4.Text = "";
                haTB5.Text = "";
                bTB6.Text = "";
                cTB7.Text = "";
                vTB8.Text = "";
                erTB9.Text = "";

                MessageBox.Show("Reset is Done.");
            }
        }
    }
}
