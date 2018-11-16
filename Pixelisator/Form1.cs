using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Pixelisator
{
    public partial class Form1 : Form
    {
        //- -- -+- -- - Class Data - -- -+- -- -
        Image PictureFromFile;
        bool isOpened = false;
        //- -- -+- -- - Class Data - -- -+- -- -

        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += Button4_Click;
            button5.Click += Button5_Click;
            button6.Click += Button6_Click;
            button7.Click += Button7_Click;
            Data.Patterns.ChangedOnce += ChangedOnce;
        }

        private void ChangedOnce() => MessageBox.Show("Completed! There are " + Data.Progress.Counter.ToString() + " pixels changed!");

        //- -- -+- -- - File Part - -- -+- -- -
        void OpenImage()
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                PictureFromFile = Image.FromFile(openFileDialog1.FileName);
                LeftPicture.Image = PictureFromFile;
                RightPicture.Image = PictureFromFile;
                isOpened = true;
            }
        }

        public void Reload()
        {
            if (!isOpened)
                MessageBox.Show("Open an Image then apply changes");
            else if (isOpened)
            {
                PictureFromFile = Image.FromFile(openFileDialog1.FileName);
                RightPicture.Image = PictureFromFile;
                isOpened = true;
            }
        }

        void SaveImage()
        {
            if (isOpened)
            {
                SaveFileDialog sfd = new SaveFileDialog { Filter = "Images|*.png;*.bmp;*.jpg" };
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    RightPicture.Image.Save(sfd.FileName, format);
                }
            }
            else
                MessageBox.Show("No image loaded, first upload image ");
        }
        //- -- -+- -- - File Part - -- -+- -- -



        //- -- -+- -- - Buttons Interface - -- -+- -- -
        private void Button1_Click(object sender, EventArgs e) => OpenImage();
        private void Button2_Click(object sender, EventArgs e) => SaveImage();
        private void Button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            Data.Patterns.ImageToBitmap(PictureFromFile);
            Data.Patterns.PlusEdit();
            Data.Progress.ShowResult();
            progressBar1.Value = 1000;
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            Data.Patterns.ImageToBitmap(PictureFromFile);
            Data.Patterns.PlusEdit();
            Data.Progress.ShowResult();
            progressBar1.Value = 1000;
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            Data.Patterns.ImageToBitmap(PictureFromFile);
            Data.Patterns.PlusEdit();
            Data.Progress.ShowResult();
            progressBar1.Value = 1000;
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            Data.Patterns.ImageToBitmap(PictureFromFile);
            Data.Patterns.PlusEdit();
            Data.Progress.ShowResult();
            progressBar1.Value = 1000;
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            Data.Patterns.ImageToBitmap(PictureFromFile);
            Data.Patterns.PlusEdit();
            Data.Progress.ShowResult();
            progressBar1.Value = 1000;
        }
        //- -- -+- -- - Buttons Interface - -- -+- -- -

        //- -- -+- -- - Drawing Engine - -- -+- -- -
       
        //- -- -+- -- - Drawing Engine - -- -+- -- -
    }
}
