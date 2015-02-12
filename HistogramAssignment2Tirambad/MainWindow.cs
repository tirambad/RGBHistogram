using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace HistogramAssignment2Tirambad
{
    public partial class MainWindow : Form
    {
        private Bitmap origImage;
        private Bitmap image;
        private bool imageFit = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    origImage = new Bitmap(openFileDialog.FileName);

                    // Convert pixel format
                    origImage = origImage.Clone(new Rectangle(0, 0, origImage.Width, origImage.Height), PixelFormat.Format32bppArgb);
                    image = new Bitmap(origImage);

                    pictureBox.Image = origImage;
                    pictureBox.Size = origImage.Size;

                    // Resize window
                    int newWidth = Math.Max(this.PreferredSize.Width, 305);
                    int newHeight = this.PreferredSize.Height;
                    newWidth = Math.Min(newWidth, Screen.PrimaryScreen.Bounds.Width * 2 / 3);
                    newHeight = Math.Min(newHeight, Screen.PrimaryScreen.Bounds.Height * 2 / 3);
                    this.Size = new Size(newWidth, newHeight);

                    // Enable buttons
                    foreach (Control c in this.Controls)
                    {
                        if (c is Button)
                            c.Enabled = true;
                    }

                    imageFit = false;
                }
                catch
                {
                    MessageBox.Show("Can't open file.");
                }
            }
        }

        public static Bitmap ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            double ratioX = (double)maxWidth / image.Width;
            double ratioY = (double)maxHeight / image.Height;
            double ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(image.Width * ratio);
            int newHeight = (int)(image.Height * ratio);

            Bitmap newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            return newImage;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            Button senderBtn = (Button)sender;
            string title = "";

            double minColor = 255;
            double maxColor = -255;
            double newColor;
            byte color;

            Bitmap newImage = new Bitmap(image);
            Rectangle rect = new Rectangle(0, 0, newImage.Width, newImage.Height);
            BitmapData bmpData = newImage.LockBits(rect, ImageLockMode.ReadWrite, newImage.PixelFormat);

            IntPtr ptr = bmpData.Scan0;

            int bytes = bmpData.Stride * bmpData.Height;
            byte[] rgbaValues = new byte[bytes];
            int[] redDistribution = new int[256];
            int[] greenDistribution = new int[256];
            int[] blueDistribution = new int[256];

            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbaValues, 0, bytes);

           if (senderBtn.Name == "rButton")
            {
              
                for (int i = 2; i < rgbaValues.Length - 1; i += 4)
                {
                    //rgbaValues[i - 1] = rgbaValues[i - 2] = rgbaValues[i];
                    redDistribution[rgbaValues[i]]++;
                }

                //debug code
                int N = 0, sum = 0;
                double sqrdiff = 0;
                double average;
                for (int j = 0; j < redDistribution.Length; j++)
                {
                    N += redDistribution[j];
                    sum += (j * redDistribution[j]);

                    //Console.WriteLine(j + " " + greenDistribution[j]);
                }
                average = sum / N;

                for (int j = 0; j < redDistribution.Length; j++)
                {
                    // N += greenDistribution[j];
                    sqrdiff += (j - average) * (j - average);
                    //sum += (j * greenDistribution[j]);

                    //Console.WriteLine(j + " " + greenDistribution[j]);
                }
                Console.WriteLine("Red Mean = " + average);
                Console.WriteLine("Red Variance = " + sqrdiff / N);

                Histogram form = new Histogram();
                form.data = redDistribution;
                form.title = "Red Histogram";
                form.mean = average;
                form.variance = sqrdiff / N;
                form.Show();
                //title = "Red";
            }
            else if (senderBtn.Name == "gButton")
            {
               for (int i = 1; i < rgbaValues.Length - 2; i += 4)
                {
                    //rgbaValues[i + 1] = rgbaValues[i - 1] = rgbaValues[i];
                    greenDistribution[rgbaValues[i]]++;
                }

               //debug code
               int N = 0, sum = 0; 
                   double sqrdiff=0 ;
               double average;
               for (int j = 0; j < greenDistribution.Length; j++)
               {
                   N += greenDistribution[j];
                   sum += (j * greenDistribution[j]);
                   
                   //Console.WriteLine(j + " " + greenDistribution[j]);
               }
               average = sum / N;

               for (int j = 0; j < greenDistribution.Length; j++)
               {
                  // N += greenDistribution[j];
                   sqrdiff += (j - average)*(j-average);
                   //sum += (j * greenDistribution[j]);

                   //Console.WriteLine(j + " " + greenDistribution[j]);
               }
               Console.WriteLine("Green Mean = " + average);
               Console.WriteLine("Green Variance = " + sqrdiff/N);
               Histogram form = new Histogram();

               form.data = greenDistribution;
               form.title = "Green Histogram";
               form.mean = average;
               form.variance = sqrdiff / N;
               form.Show();
                //title = "Green";
            }
            else if (senderBtn.Name == "bButton")
            {
                for (int i = 0; i < rgbaValues.Length - 3; i += 4)
                {
                    //rgbaValues[i + 2] = rgbaValues[i + 1] = rgbaValues[i];
                    blueDistribution[rgbaValues[i]]++;
                }

                //debug code
                //debug code
                int N = 0, sum = 0;
                double sqrdiff = 0;
                double average;
                for (int j = 0; j < blueDistribution.Length; j++)
                {
                    N += blueDistribution[j];
                    sum += (j * blueDistribution[j]);

                    //Console.WriteLine(j + " " + greenDistribution[j]);
                }
                average = sum / N;

                for (int j = 0; j < blueDistribution.Length; j++)
                {
                    // N += greenDistribution[j];
                    sqrdiff += (j - average) * (j - average);
                    //sum += (j * greenDistribution[j]);

                    //Console.WriteLine(j + " " + greenDistribution[j]);
                }
                Console.WriteLine("Blue Mean = " + average);
                Console.WriteLine("Blue Variance = " + sqrdiff / N);

                Histogram form = new Histogram();
                form.data = blueDistribution;

                form.title = "Blue Histogram";
                form.mean = average;
                form.variance = sqrdiff / N;
                form.Show();
                //title = "Blue";
            }
            

            System.Runtime.InteropServices.Marshal.Copy(rgbaValues, 0, ptr, bytes);

            newImage.UnlockBits(bmpData);

            
        }

        private void fitButton_Click(object sender, EventArgs e)
        {
            image = ScaleImage(origImage, this.ClientRectangle.Width - pictureBox.Left - 3, this.ClientRectangle.Height - pictureBox.Top - 3);
            pictureBox.Image = image;
            pictureBox.Size = image.Size;
            imageFit = true;
            this.Size = this.PreferredSize;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
