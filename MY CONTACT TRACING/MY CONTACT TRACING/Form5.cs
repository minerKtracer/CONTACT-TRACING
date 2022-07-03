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
 

        }
    }
}
