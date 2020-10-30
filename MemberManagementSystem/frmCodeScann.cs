using AForge.Imaging;
using AForge.Video;
using CodeScaner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;
namespace MemberManagementSystem
{
    public partial class frmCodeScann : Form
    {
        public static CamControl camControl;
        public static Timer webCamTimer;
        private readonly BarcodeReader barcodeReader;
        private readonly IList<ResultPoint> resultPoints;
        private readonly IList<Result> lastResults;
        private EncodingOptions EncodingOptions { get; set; }
        private Type Renderer { get; set; }
        private bool TryMultipleBarcodes { get; set; }
        private bool TryOnlyMultipleQRCodes { get; set; }

        public frmCodeScann()
        {
            camControl = new CamControl();
            InitializeComponent();
            barcodeReader = new BarcodeReader
            {
                AutoRotate = true,
                TryInverted = true,
                Options = new DecodingOptions { TryHarder = true }
            };
            barcodeReader.ResultPointFound += point =>
            {
                if (point == null)
                    resultPoints.Clear();
                else
                    resultPoints.Add(point);
            };

            resultPoints = new List<ResultPoint>();
            lastResults = new List<Result>();
            Renderer = typeof(BitmapRenderer);

            if (frmLogin.UserLevel == 2)
            {
                frmMainMenu mianColor = new frmMainMenu();
                this.BackColor = mianColor.color3;
            }

        }


        public static string qrCode = string.Empty;

        private void tWebCamTimer_Tick(object sender, EventArgs e)
        {
            if (picWebCam.Image != null)
            {

                try
                {
                    var bitmap = new System.Drawing.Bitmap(picWebCam.Image);
                    if (bitmap == null)
                        return;
                    var reader = new BarcodeReader();
                    var result = reader.Decode(bitmap);
                    if (result != null)
                    {
                        //码型
                        //   txtTypeWebCam.Text = result.BarcodeFormat.ToString();
                        //获取结果
                        qrCode = result.Text;
                        Console.Beep(500, 500);
                        picWebCam.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    if (camControl.SelectedDevice.IsRunning)
                    {
                        camControl.SelectedDevice.SignalToStop();
                    }
                    webCamTimer.Stop();
                    webCamTimer = null;
                    picWebCam.Image = null;
                    System.Windows.Forms.MessageBox.Show(ex.Message.ToString());

                }
                finally
                {

                }
            }
        }


        void captureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            using (UnmanagedImage uimage = UnmanagedImage.FromManagedImage(eventArgs.Frame))
            {
                try
                {
                    ///picWebCam.Image = null;
                    picWebCam.Image = new System.Drawing.Bitmap(uimage.ToManagedImage());
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.ToString());
                }
            }

        }

        /// <summary>
        /// 停止扫描
        /// </summary>
        public static void StopScann()
        {
            if (startState == true)
            {
                if (camControl.SelectedDevice.IsRunning)
                {
                    camControl.SelectedDevice.SignalToStop();
                }
                webCamTimer.Stop();
                webCamTimer = null;
                startState = false;
            }

        }

        static bool startState = false;
        private void frmCodeScann_Load(object sender, EventArgs e)
        {
            startState = true;
            //使用当前设备进行扫描二维码
            camControl.SetCamera(BasicSetup.Default.Webcam);
            camControl.SelectedDevice.NewFrame += new NewFrameEventHandler(captureDevice_NewFrame);
            camControl.SelectedDevice.Start();
            webCamTimer = new Timer();
            webCamTimer.Tick += tWebCamTimer_Tick;
            webCamTimer.Interval = 200;
            webCamTimer.Start();
        }

    }
}
