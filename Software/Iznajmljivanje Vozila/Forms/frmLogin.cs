using AForge.Video.DirectShow;
using AForge.Video;
using BusinessLogicLayer.Services;
using Iznajmljivanje_Vozila.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iznajmljivanje_Vozila
{
    public partial class FrmLogin : MaterialForm
    {
        private VideoCaptureDevice videoSource;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void InitializeWebcam()
        {
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
                videoSource.Start();
            }
            else
            {
                MessageBox.Show("No video devices found.");
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Clone the frame
            System.Drawing.Image frame = (System.Drawing.Image)eventArgs.Frame.Clone();

            // Resize the image to fit in the PictureBox while maintaining the aspect ratio
            ResizeImageToFitPictureBox(frame, pbImage);

            // Display the resized image
            pbImage.Image = frame;
        }

        private void ResizeImageToFitPictureBox(System.Drawing.Image image, PictureBox pictureBox)
        {
            if (image != null)
            {
                // Calculate the aspect ratio of the image
                double aspectRatio = (double)image.Width / image.Height;

                // Calculate the new width and height to fit within the PictureBox
                int newWidth = pictureBox.Width;
                int newHeight = (int)(newWidth / aspectRatio);

                // If the new height exceeds the PictureBox height, calculate based on height
                if (newHeight > pictureBox.Height)
                {
                    newHeight = pictureBox.Height;
                    newWidth = (int)(newHeight * aspectRatio);
                }

                // Resize the image
                pictureBox.Image = new Bitmap(image, newWidth, newHeight);
            }
        }

        // Don't forget to handle the FormClosing event to stop the webcam when closing the form
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }
        MaterialSkinManager TManager = MaterialSkinManager.Instance;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default.Theme == true)
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                TManager.Theme = MaterialSkinManager.Themes.DARK;
            
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            await PerformLogin();
        }

        private async Task PerformLogin()
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            var loginService = new LoginService();

            var login = await loginService.LoginUsernamePassword(username, password);

            if (login)
            {
                //MessageBox.Show("Uspješna prijava");
                this.Hide();
                frmVehicleStatus frmVehicleStatus = new frmVehicleStatus();
                frmVehicleStatus.Closed += (s, args) => this.Close(); 
                frmVehicleStatus.Show();
                
            }
            else
            {
                MessageBox.Show("Neuspješna prijava");
            }
        }

        private void btnTurnOnCamera_Click(object sender, EventArgs e)
        {
            InitializeWebcam();
        }
    }
}
