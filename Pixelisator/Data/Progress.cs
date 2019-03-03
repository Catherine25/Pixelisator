using System.Drawing;

namespace Pixelisator.Data {
    static class Progress {
        static public int Counter { get; set; }
        static public int Step { get; set; }
        static public Graphics OutGraphics { get; set; }
        static public Image WorkImage { get; set; }

        static public void ShowResult() {
           OutGraphics = Graphics.FromImage(ImageController.getBitmapAsImage());

            OutGraphics.DrawImage(ImageController.getBitmapAsImage(),
                new Rectangle(0, 0, ImageController.getWorkImageWidth(), ImageController.getWorkImageHeight()),
                0, 0, ImageController.getWorkImageWidth(), ImageController.getWorkImageHeight(), GraphicsUnit.Pixel, Patterns.imageAttributes);

            OutGraphics.Dispose();
        }
    }
}
