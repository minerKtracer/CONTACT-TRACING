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
                    TxtBShow.Text = result.ToString();
                    Ftimer.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            
        }
    }
}
