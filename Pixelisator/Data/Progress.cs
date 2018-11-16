﻿using System.Drawing;
using System.Windows.Forms;

namespace Pixelisator.Data
{
    static class Progress
    {
        static Progress()
        {
        }
        //data
        static public int counter;
        static public int Counter { get { return counter; }
            set
            {
                if (counter != value)
                {
                    counter = value;
                    CounterChanged();
                }
            }
        }
        static public Graphics OutGraphics { get; set; }
        static Image WorkImage { get; set; }
        static public event System.Action CounterChanged;
        //MessageBox.Show("Completed! There are " + Progress.Counter.ToString() + " pixels changed!");
        //static Progress() => Counter = 0;

        static public void ShowResult()
        {
            OutGraphics = Graphics.FromImage(Patterns.Bitmap);
            WorkImage = Patterns.Bitmap;

            OutGraphics.DrawImage(WorkImage,
                new Rectangle(0, 0, WorkImage.Width, WorkImage.Height),
                0, 0, WorkImage.Width, WorkImage.Height, GraphicsUnit.Pixel);

            OutGraphics.Dispose();
        }

        //static void ShowMessage() => MessageBox.Show("Completed! There are " + Progress.Counter.ToString() + " pixels changed!");
    }
}
