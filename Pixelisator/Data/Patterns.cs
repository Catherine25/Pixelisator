using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Pixelisator.Data {
    static class Patterns {
        //constructors
        static Patterns() {
            imageAttributes = new ImageAttributes();
            ChangedOnce = new System.Action(ShowMessage);
        }

        //data
        static public event System.Action ChangedOnce;
        static public ImageAttributes imageAttributes;

        //methods
        static void ShowMessage() {
            MessageBox.Show("Completed! There are " +
            Progress.Counter.ToString() +
            " pixels changed!");
        }
        static public Color[] GetMatrix(int x, int y) {
            Color[] colors = new Color[4] {
                Data.ImageController.getPixel(x, y),
                Data.ImageController.getPixel(x+1, y),
                Data.ImageController.getPixel(x, y+1),
                Data.ImageController.getPixel(x+1, y+1)
            };
            return colors;
        }
        public static void RedAccent() {
            int w = Data.ImageController.getWorkImageWidth(),
            h = Data.ImageController.getWorkImageHeight();
            int min, allMin;

            for (int x = 0; x < w-1; x++)
                for (int y = 0; y < h-1; y++) {
                    Color curPixel = Data.ImageController.getPixel(x, y);
                    min = System.Math.Min(curPixel.G, curPixel.B);
                    allMin = System.Math.Min(min, curPixel.R);

                    if (curPixel.R - Progress.Step < curPixel.G || curPixel.R - Progress.Step < curPixel.B)
                        curPixel = Color.FromArgb(allMin, allMin, allMin);
                    Data.ImageController.setPixel(x, y, curPixel);
                }
        }

        public static void GreenAccent() {
            int min, allMin;
            int w = Data.ImageController.getWorkImageWidth(),
            h = Data.ImageController.getWorkImageHeight();

            for (int x = 0; x < w-1; x++)
                for (int y = 0; y < h-1; y++) {
                    Color curPixel = Data.ImageController.getPixel(x, y);
                    min = System.Math.Min(curPixel.R, curPixel.B);
                    allMin = System.Math.Min(min, curPixel.G);
                    if (curPixel.G - Progress.Step < curPixel.R || curPixel.G - Progress.Step < curPixel.B)
                        curPixel = Color.FromArgb(allMin, allMin, allMin);
                    Data.ImageController.setPixel(x, y, curPixel);
                }
        }

        public static void BlueAccent() {
            int w = Data.ImageController.getWorkImageWidth(),
            h = Data.ImageController.getWorkImageHeight();
            int min, allMin;

            for (int x = 0; x < w-1; x++)
                for (int y = 0; y < h-1; y++) {
                    Color curPixel = Data.ImageController.getPixel(x, y);
                    min = System.Math.Min(curPixel.R, curPixel.G);
                    allMin = System.Math.Min(min, curPixel.B);
                    if (curPixel.B - Progress.Step < curPixel.R || curPixel.B - Progress.Step < curPixel.G)
                        curPixel = Color.FromArgb(allMin, allMin, allMin);
                    Data.ImageController.setPixel(x, y, curPixel);
                }
        }

        public static void ThreeToOneEdit() {
            int h = Data.ImageController.getWorkImageHeight()-2,
            w = Data.ImageController.getWorkImageWidth()-2;

            for (int i = 0; i < h; i++)
                for (int j = 0; j < w; j++) {
                    if (i % 2 != 0 || i % 2 != 0)
                        continue;
                    Color[] colors = GetMatrix(h,w);
                    colors[1] = colors[0];
                    colors[2] = colors[0];
                    colors[3] = colors[0];
                }
        }
    }
}
