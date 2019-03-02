using System.Drawing;

namespace Pixelisator.Data {
    static class ImageController {
        public static Image WorkImage {
            get { return workImage; }
            set { workImage = value; }
            }

            public static Image LoadedImage {
                get { return loadedImage; }
                set { loadedImage = value; }
            }

        private static Image workImage;

        private static Image loadedImage;
    }
}