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
using ZXing;
using ZXing.Aztec;
using System.IO;

namespace MY_CONTACT_TRACING
{
    public partial class QRcodepass : Form
    {
        public QRcodepass()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void QRcodepass_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                CBox.Items.Add(filterInfo.Name);
            CBox.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[CBox.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            Ftimer.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            PBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void QRcodepass_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void Ftimer_Tick(object sender, EventArgs e)
        {
            if (PBox.Image != null)
            {      
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)PBox.Image);
                if (result != null)
                {
                    var qrResult = result.Text.Split(new char[] { '\n' , ',' });
                    if (qrResult.Length == 9)
                        fnTB1.Text = qrResult[0];
                        aTB2.Text = qrResult[1];
                        sTB3.Text = qrResult[2];
                        pnTB4.Text = qrResult[3];
                        haTB5.Text = qrResult[4];
                        bTB6.Text = qrResult[5];
                        cTB7.Text = qrResult[6];
                        vTB8.Text = qrResult[7];
                        erTB9.Text = qrResult[8];
                    Ftimer.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();

                }
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Kylene Shane M. Varona from BSCOE 1-5", "BASIC INFO");
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\kylene shane varona\Desktop\MY ASSIGN 3\ContactTracingQRCode.txt", true);
            file.WriteLine("Information of the person :");
            file.WriteLine("Full Name: " + fnTB1.Text);
            file.WriteLine("Age: " + aTB2.Text);
            file.WriteLine("Sex (F/M): " + sTB3.Text);
            file.WriteLine("Phone Number: " + pnTB4.Text);
            file.WriteLine("Home Address: " + haTB5.Text);
            file.WriteLine("Barangay: " + bTB6.Text);
            file.WriteLine("City: " + cTB7.Text);
            file.WriteLine("Are you fully vacinated? : " + vTB8.Text);
            file.WriteLine("Exposure Risk? : " + erTB9.Text);
            file.Close();

            MessageBox.Show("Done");
        
        }
    }
}
