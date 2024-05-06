namespace Pictures
{
    public partial class Form1 : Form
    {
        private Bitmap? image;
        private string imagePath;
        private int tresholdValue = 80;
        public readonly object locker = new object();
        public Form1()
        {
            InitializeComponent();
            mainImage.SizeMode = PictureBoxSizeMode.StretchImage;
            grayPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            edgeDetectPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            negativePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            tresholdingPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackgroundImage = Image.FromFile("C://Users//Justyna//Desktop//.Net-and-Java//MatrixMulitplication//Pictures//tlo.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|Allfiles (*.*)|*.*,";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;

                if (imagePath != null)
                {
                    image = new Bitmap(imagePath);
                    mainImage.Image = image;
                }
            }
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                Thread[] threads = new Thread[4];

                threads[0] = new Thread(SobelEdgeDetection);
                threads[1] = new Thread(convertToGrayThread);
                threads[2] = new Thread(convertToNegative);
                threads[3] = new Thread(treshold);

                foreach (Thread thread in threads) { thread.Start(); }
                foreach (Thread thread in threads) { thread.Join(); }

            }

        }

        private void SobelEdgeDetection()
        {
            Bitmap gray;
            lock (locker)
            {
                gray = convertToGray(image);
            }

            Bitmap edgeImage = new Bitmap(gray.Width, gray.Height);

            int[,] xFilter = { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            int[,] yFilter = { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };

            for (int i = 1; i < gray.Width - 1; i++)
            {
                for (int j = 1; j < gray.Height - 1; j++)
                {
                    int pixelX = Filter(gray, xFilter, i, j);
                    int pixelY = Filter(gray, yFilter, i, j);
                    int edge = (int)Math.Sqrt((pixelX * pixelX) + (pixelY * pixelY));
                    edge = Math.Max(0, Math.Min(255, edge));
                    edgeImage.SetPixel(i, j, Color.FromArgb(edge, edge, edge));

                }
            }
            edgeDetectPictureBox.Image = edgeImage;

        }
        private int Filter(Bitmap image, int[,] filter, int x, int y)
        {
            int filterWidth = filter.GetLength(0);
            int filterHeight = filter.GetLength(1);
            int output = 0;

            for (int i = 0; i < filterWidth; i++)
            {
                for (int j = 0; j < filterHeight; j++)
                {
                    int imageX = (x - filterWidth / 2 + i + image.Width) % image.Width;
                    int imageY = (y - filterHeight / 2 + j + image.Height) % image.Height;
                    Color imageColor = image.GetPixel(imageX, imageY);
                    output += imageColor.R * filter[i, j];
                }

            }
            return output;
        }
        private void convertToGrayThread()
        {
            lock (locker)
            {
                grayPictureBox.Image = convertToGray(image);
            }
        }

        private Bitmap convertToGray(Bitmap image)
        {
            Bitmap grayImage = new Bitmap(image.Width, image.Height);

            for (int i = 0; i < grayImage.Width; i++)
            {
                for (int j = 0; j < grayImage.Height; j++)
                {
                    Color colorOriginal = image.GetPixel(i, j);
                    int grayScale = (colorOriginal.R + colorOriginal.G + colorOriginal.B) / 3;
                    Color grayColor = Color.FromArgb(colorOriginal.A, grayScale, grayScale, grayScale);
                    grayImage.SetPixel(i, j, grayColor);

                }
            }
            return grayImage;
        }

        private void convertToNegative()
        {
            Bitmap negativeImage;
            lock (locker)
            {
                negativeImage = new Bitmap(image.Width, image.Height);
            }

            for (int i = 0; i < negativeImage.Width; i++)
            {
                for (int j = 0; j < negativeImage.Height; j++)
                {
                    Color original;
                    lock (locker) { original = image.GetPixel(i, j); }

                    Color negative = Color.FromArgb(255 - original.R, 255 - original.G, 255 - original.B);
                    negativeImage.SetPixel(i, j, negative);
                }
            }
            negativePictureBox.Image = negativeImage;
        }

        private void treshold()
        {
            int treshold = tresholdValue;

            Bitmap tresholded;
            Bitmap gray;
            lock (locker)
            {
                tresholded = new Bitmap(image.Width, image.Height);
                gray = convertToGray(image);
            }

            for (int i = 0; i < tresholded.Width; i++)
            {
                for (int j = 0; j < tresholded.Height; j++)
                {
                    Color color = gray.GetPixel(i, j);
                    if (color.R < treshold)
                    {
                        tresholded.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        tresholded.SetPixel(i, j, Color.White);
                    }
                }
            }
            tresholdingPictureBox.Image = tresholded;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
