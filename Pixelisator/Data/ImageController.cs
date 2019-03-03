using System.Drawing;

namespace Pixelisator.Data {
    static class ImageController {
        //accessors
        // public static Image WorkImage {
        //     get { return workImage; }
        //     set { workImage = value; }
        //     }

        //data
        //private static Image workImage;
        private static Bitmap bitmap;

        //metods
        public static void setImageToBitmap(Image image) { bitmap = (Bitmap)image; }
        public static Image getBitmapAsImage() { return (Image)bitmap; }
        public static Color getPixel(int x, int y) { return bitmap.GetPixel(x, y); }
        public static void setPixel(int x, int y, Color c) { bitmap.SetPixel(x, y, c); }
        public static int getWorkImageWidth() { return bitmap.Width; }
        public static int getWorkImageHeight() { return bitmap.Height; }
    }
}