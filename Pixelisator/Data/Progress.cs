using System.Drawing;

namespace Pixelisator.Data
{
    static class Progress
    {
        //data
        static public int Counter { get; set; }
        static public int Step { get; set; }
        static public Graphics OutGraphics { get; set; }
        static public Image WorkImage { get; set; }

        static public void ShowResult()
        {
           OutGraphics = Graphics.FromImage(WorkImage);

            OutGraphics.DrawImage(WorkImage,
                new Rectangle(0, 0, WorkImage.Width, WorkImage.Height),
                0, 0, WorkImage.Width, WorkImage.Height, GraphicsUnit.Pixel, Patterns.imageAttributes);

            OutGraphics.Dispose();
        }
    }
}
