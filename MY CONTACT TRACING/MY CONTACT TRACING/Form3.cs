using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;


namespace MY_CONTACT_TRACING
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void BtnManual_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManualPass Mp = new ManualPass();
            Mp.ShowDialog(); // Shows Manual Pass

            this.Show();
        }

        private void BtnQRCode_Click(object sender, EventArgs e)
        {
            this.Hide();
            QRHome QH = new QRHome();
            QH.ShowDialog(); // Shows QRHome

            this.Show();
        }
    }
}
