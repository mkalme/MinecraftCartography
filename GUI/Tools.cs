using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace GUI {
    class Tools {
        public static void SaveImage(Bitmap image, string path)
        {
            string extension = Path.GetExtension(path);

            ImageFormat format = ImageFormat.Png;
            switch (extension) {
                case ".bmp":
                    format = ImageFormat.Bmp;
                    break;
                case ".jpeg":
                    format = ImageFormat.Jpeg;
                    break;
            }

            image.Save(path, format);
        }
        public static void CopyToClipboard(Image image)
        {
            if (image != null) {
                Clipboard.SetImage(image);
            }
        }
    }
}
