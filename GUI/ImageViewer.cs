using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace GUI {
    public partial class ImageViewer : Form {
        private Bitmap Image { get; set; }

        public ImageViewer(Bitmap image)
        {
            InitializeComponent();

            Image = image;
        }

        private void MapForm_Load(object sender, EventArgs e)
        {
            DisplayImage();
        }

        private void DisplayImage() {
            Image image = ResizeImage(Panel.Size);

            PictureBox.Image = image;
            PictureBox.Size = image.Size;

            SetPictureBoxLocation();
        }
        private void SetPictureBoxLocation() {
            Point point = new Point(
                (Panel.Width - PictureBox.Width) / 2 + XOffset,
                (Panel.Height - PictureBox.Height) / 2 + YOffset);

            PictureBox.Location = point;
        }

        //Move
        private bool Drag = false;
        private Cords Point { get; set; }
        private int XOffset = 0, YOffset = 0;

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Point = new Cords(e.X, e.Y);
            Drag = true;
        }
        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            Drag = false;
        }
        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag) {
                XOffset += e.X - Point.X;
                YOffset += e.Y - Point.Y;

                SetPictureBoxLocation();
            }
        }

        private void MovePictureBox(int left, int up)
        {
            PictureBox.Location = new Point(PictureBox.Location.X - left, PictureBox.Location.Y - up);
        }

        //Resize
        private readonly float PercentagePerDelta = 0.001F; // 100
        private readonly int MaxPixelPerPixel = 4;

        private void Panel_MouseWheel(object sender, MouseEventArgs e)
        {
            float ratio = GetRatio(e.Delta);

            int left, up;
            Size newSize;

            SetLocation(
                ratio,
                new Cords(e.X - PictureBox.Location.X, e.Y - PictureBox.Location.Y),
                out left, out up, out newSize);

            MovePictureBox(left, up);

            Image resizedImage = ResizeImage(newSize);
            PictureBox.Image = resizedImage;
            PictureBox.Size = newSize;
        }

        private float GetRatio(int delta) {
            float ratio = 1 + delta * PercentagePerDelta;
            if (delta < 0) {
                ratio = 1 / (1 - delta * PercentagePerDelta);
            }

            float nextPixelDensity = (PictureBox.Width * ratio) / Image.Width;
            if (nextPixelDensity > MaxPixelPerPixel) {
                ratio = MaxPixelPerPixel * Image.Width / PictureBox.Width;
            }

            return ratio;
        }
        private void SetLocation(float ratio, Cords mouseCords, out int left, out int up, out Size newSize) {
            float xPercentage = mouseCords.X / (float)PictureBox.Width;
            float yPercentage = mouseCords.Y / (float)PictureBox.Height;

            newSize = new Size((int)(PictureBox.Width * ratio), (int)(PictureBox.Height * ratio));

            left = (int)(xPercentage * (newSize.Width - PictureBox.Width));
            up = (int)(yPercentage * (newSize.Height - PictureBox.Height));
        }

        //Scripts
        private void ImageViewer_Resize(object sender, EventArgs e)
        {
            DisplayImage();
        }

        private Bitmap ResizeImage(Size frame)
        {
            int pictureWidth = frame.Width;
            int pictureHeight = frame.Height;

            int width = (int)((Image.Width / (double)Image.Height) * pictureHeight);
            int height = pictureHeight;

            if (width > pictureWidth) {
                width = pictureWidth;
                height = (int)((Image.Height / (double)Image.Width) * width);
            }

            if (width == 0 || height == 0) return Image;

            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result)) {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(Image, 0, 0, width, height);
            }
            return result;
        }

        //ToolBar
        private void ClipboardLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tools.CopyToClipboard(Image);
        }
        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog.ShowDialog();

            if (Directory.Exists(Path.GetDirectoryName(SaveFileDialog.FileName))) {
                Tools.SaveImage(Image, SaveFileDialog.FileName);
            }
        }
    }

    class Cords {
        public int X { get; set; }
        public int Y { get; set; }

        public Cords(int x, int y) {
            X = x;
            Y = y;
        }
    }
}
