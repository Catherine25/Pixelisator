using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;
using static Pixelisator.Data.FileController;

namespace Pixelisator
{
    public partial class Form1 : Form {
        //public ref OpenFileDialog GetDialog() { return ref openFileDialog1; }

        public Form1()
        {
            InitializeComponent();
            RightPicture.MouseDown += RightPicture_MouseDown; ;
            openBt.Click += OpenBt;
            saveBt.Click += SaveBt;
            redBt.Click += RedAccent;
            greenBt.Click += GreenAccentBt;
            blueBt.Click += BlueAccentBt;
            button6.Click += Button6_Click;
            button7.Click += Button7_Click;
            //Data.Patterns.ChangedOnce += Progress_ChangedOnce;
            numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;
        }

        private void RightPicture_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X, 
                y = e.Y;

            // if (x == 1 || y == 1)
                // RightPicture.Hide();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e) => Data.Progress.Step = (int)numericUpDown1.Value;

        //private void Progress_ChangedOnce() { }

        //Buttons Interface
        private void OpenBt(object sender, EventArgs e) => Data.FileController.OpenImage(ref this.openFileDialog1);
        private void SaveBt(object sender, EventArgs e) => Data.FileController.SaveImage();
        private void RedAccent(object sender, EventArgs e) {

            progressBar1.Value = 0;
            Data.Patterns.ImageToBitmap();
            Data.Patterns.RedAccent();
            Data.Patterns.BitmapToImage();
            Data.Progress.ShowResult();
            Reload();

            progressBar1.Value = 1000;
        }
        private void GreenAccentBt(object sender, EventArgs e) {
            progressBar1.Value = 0;
            Data.Patterns.ImageToBitmap();
            Data.Patterns.GreenAccent();
            Data.Patterns.BitmapToImage();
            Data.Progress.ShowResult();

            Reload();
            progressBar1.Value = 1000;
        }
        private void BlueAccentBt(object sender, EventArgs e) {

            progressBar1.Value = 0;

            Data.Patterns.ImageToBitmap();
            Data.Patterns.BlueAccent();
            Data.Patterns.BitmapToImage();
            Data.Progress.ShowResult();

            Reload();

            progressBar1.Value = 1000;
        }
        private void Button6_Click(object sender, EventArgs e) {

            progressBar1.Value = 0;
            Data.Patterns.ImageToBitmap();
            Data.Patterns.ThreeToOneEdit();
            Data.Progress.ShowResult();
            progressBar1.Value = 1000;
        }
        private void Button7_Click(object sender, EventArgs e) {

            progressBar1.Value = 0;
            Data.Patterns.ImageToBitmap();
            Data.Progress.ShowResult();
            progressBar1.Value = 1000;
        }
    }
}
