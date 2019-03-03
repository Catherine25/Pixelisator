using System.Drawing;

namespace Pixelisator.Data {
    static class ImageController {
        //accessors
        public static Image WorkImage {
            get { return workImage; }
            set { workImage = value; }
            }
        public static Image LoadedImage {
            get { return loadedImage; }
            set { loadedImage = value; }
            }

        //data
        private static Image workImage;
        private static Image loadedImage;
        private static Bitmap bitmap;

        //metods
        public static void ImageToBitmap() { bitmap = (Bitmap)Progress.WorkImage; }
        public static void BitmapToImage() { Progress.WorkImage = bitmap; }
        public static Color getPixel(int x, int y) { return bitmap.GetPixel(x, y); }
        public static void setPixel(int x, int y, Color c) { bitmap.SetPixel(x, y, c); }
        public static int getWorkImageWidth() { return bitmap.Width; }
        public static int getWorkImageHeight() { return bitmap.Height; }
    }
}