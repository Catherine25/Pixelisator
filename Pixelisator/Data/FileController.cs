using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Pixelisator.Data {
    static class FileController {

        static public void OpenImage(ref OpenFileDialog dialog) {
            DialogResult dr = dialog.ShowDialog();
            if (dr == DialogResult.OK) {
                Data.ImageController.setImageToBitmap(Image.FromFile(dialog.FileName));
                Data.Flags.isOpen = true;
            }
        }
        static public void Reload(ref OpenFileDialog openFileDialog,
        ref PictureBox picture) {
            if (!Flags.isOpen)
                MessageBox.Show("Open an Image then apply changes");
            else if (Flags.isOpen) {
                picture.Image = Image.FromFile(openFileDialog.FileName);
                Flags.isOpen = true;
            }
        }

        static public void SaveImage() {

            if (Flags.isOpen) {
                SaveFileDialog sfd = new SaveFileDialog { Filter = "Images|*.png;*.bmp;*.jpg" };
                ImageFormat format = ImageFormat.Png;

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    string ext = Path.GetExtension(sfd.FileName);
                    switch (ext) {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    Data.ImageController.getBitmapAsImage().Save(sfd.FileName, format);
                }
            }
            else MessageBox.Show("No image loaded, firstly upload image");
        }
    }
}
