using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // uygulama ilk açıldığında çalışacak olan kod:
        private void Form1_Load(object sender, EventArgs e)
        {
            // pictureBox'un boyutlarını uygulama penceresine tam olarak sığdırma amaçlı kod:
            pictureBox_resim.Size = new Size(this.Width - 100, this.Height - 150);
        }

        // openFile işlemi
        private void toolStripButton_openFile_Click(object sender, EventArgs e)
        {
            // eğer kullanıcı bir resim seçtiyse:
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // kullanıcının seçmiş olduğu resim Image türünde bir nesneye dönüştürülüyor:
                //Image openedImage = Image.FromFile(openFileDialog1.FileName);
                // pictureBox'da gösteriliyor
                //pictureBox_resim.Image = (Image)openedImage.Clone();

                //********************************************************************
                // OPEN CV KODU:
                Image<Bgr, byte> img_cv = new Image<Bgr, byte>(openFileDialog1.FileName);
                pictureBox_resim.Image = img_cv.Bitmap;
                //********************************************************************

                //// 
                //pictureBox_resim.Size = new Size(openedImage.Width, openedImage.Height);

                // eğer resmin genişliği uygulamanın penceresinin genişliğinden büyükse ekran sığdırıılıyor:
                if (pictureBox_resim.Size.Width > this.Width)
                    pictureBox_resim.Size = new Size(this.Width - 100, pictureBox_resim.Size.Height);

                // eğer resmin yüksekliği uygulamanın penceresinin yüksekliğinden büyükse ekran sığdırılıyor:
                if (pictureBox_resim.Size.Height > this.Height)
                    pictureBox_resim.Size = new Size(pictureBox_resim.Size.Width, this.Height - 150);
            }
        }

        // kaydetme işlemi
        private void toolStripButton_saveFile_Click(object sender, EventArgs e)
        {
            // kullanıcı kaydet'e bastıysa ve verdiği isim en az 1 karakter ise:
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                // kullanıcının belirlediği kayıt yeri alınıyor
                string savePath = saveFileDialog1.FileName;

                // ekranda düzenlenmiş olan resimden bir Bitmap nesnesi oluşturuluyor.
                Image image = pictureBox_resim.Image;
                Bitmap bmp = new Bitmap(image);

                // kaydedilecek olan resmin uzantısı tespit ediliyor:
                string extention = ".jpg";
                //ImageFormat imgFormat = null;
                //if (openFileDialog1.FileName.EndsWith(".png"))
                //{
                //    imgFormat = ImageFormat.Png;
                //    extention = ".png";
                //}
                //else if (openFileDialog1.FileName.EndsWith(".jpg"))
                //{
                //    imgFormat = ImageFormat.Jpeg;
                //    extention = ".jpg";
                //}
                //else if (openFileDialog1.FileName.EndsWith(".bmp"))
                //{
                //    imgFormat = ImageFormat.Bmp;
                //    extention = ".jpg";
                //}

                //// kaydetme işleminde eğer kullanıcı uzantı eklemeyi unutmuşsa :)
                //if (savePath.IndexOf(".") == -1) // yani bir uzantı yoksa resimde
                //{
                //    // yani kullanıcı isim olarak "resim" girdiyse, otomatik olarak "resim.jpg" yapması için. yoksa resmi açamaz
                //    savePath = savePath + extention;
                //}

                //// yeni resim kaydediliyor
                //bmp.Save(savePath, imgFormat);

                // sadece mesaj'da kullanılacak resmin sadece adını almak için


                savePath = savePath + extention;

                //********************************************************************
                // OPEN CV KODU: resim kaydetme
                Image<Bgr, byte> img_cv = new Image<Bgr, byte>(openFileDialog1.FileName);
                img_cv.Bitmap = new Bitmap(pictureBox_resim.Image);
                img_cv.Bitmap.Save(savePath);
               
                //********************************************************************

                // normal savePath "c:\Ts\masaüstü\resim1.jpg" iken fileName "resim1.jpg" olarak elde edilmektedir.
                string fileName = Path.GetFileName(savePath);
                // işlem başarılı ise kullanıcıta mesaj verilmekte:
                MessageBox.Show(fileName + " adlı resim kaydedildi.");
            }
        }

        // Reopen:
        private void toolStripButton_reopen_Click(object sender, EventArgs e)
        {
            // resmin ilk halini kullanıcya göstermek:

            // yorum satırı yapılan kısımlar(kodlar) c# otomatik kodlarıdır, deneme amaçlı idi.
            // kullanıcının seçmiş olduğu resim Image türünde bir nesneye dönüştürülüyor:
            //Image openedImage = Image.FromFile(openFileDialog1.FileName);
            // pictureBox'da gösteriliyor
            //pictureBox_resim.Image = (Image)openedImage.Clone();

            //********************************************************************
            // OPEN CV KODU: resim açma
            Image<Bgr, byte> img_cv = new Image<Bgr, byte>(openFileDialog1.FileName);
            pictureBox_resim.Image = img_cv.Bitmap;
            //********************************************************************

            // eğer resmin genişliği uygulamanın penceresinib genişliğinden büyükse ekran sığdıruılıyor:
            if (pictureBox_resim.Size.Width > this.Width)
                pictureBox_resim.Size = new Size(this.Width - 100, pictureBox_resim.Size.Height);

            // eğer resmin yüksekliği uygulamanın penceresinib yüksekliğinden büyükse ekran sığdıruılıyor:
            if (pictureBox_resim.Size.Height > this.Height)
                pictureBox_resim.Size = new Size(pictureBox_resim.Size.Width, this.Height - 150);
        }

        // NEGATIVE
        private void toolStripButton_negative_Click(object sender, EventArgs e)
        {
            // burada temel olarak yapılan Alfa kanalı hariç her pixel'e ait olan R,G,B kanallarındaki bitler terskenerek 
            // yerine yazılmaktadır.

            int i, j;
            Color r;
            Bitmap bmp = new Bitmap(pictureBox_resim.Image);
            for (i = 0; i <= bmp.Width - 1; i++)
            {
                for (j = 0; j <= bmp.Height - 1; j++)
                {
                    r = bmp.GetPixel(i, j);//i,j noktasının rengini öğren
                 
                    r = Color.FromArgb(r.A, (byte)~r.R, (byte)~r.G, (byte)~r.B);
                    bmp.SetPixel(i, j, r);//aynı noktaya tekrar koy
                }
            }

            pictureBox_resim.Image = bmp;
        }

        // MIRRORING
        private void toolStripButton_mirror_Click(object sender, EventArgs e)
        {
            // burada yapılan temel olarak her pixel okundukran sonra 
            // tam karşıdaki(x ekseninde -ki x eksenini tam resmin ortasından geçen bir eksen olarak kabul edelim-)  yerine yazılmasıdır.

            //read source image
            Bitmap simg = new Bitmap(pictureBox_resim.Image);

            //get source image dimension
            int width = simg.Width;
            int height = simg.Height;

            //mirror image
            Bitmap mimg = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int lx = 0, rx = width - 1; lx < width; lx++, rx--)
                {
                    //get source pixel value
                    Color p = simg.GetPixel(lx, y);

                    //set mirror pixel value
                    //mimg.SetPixel(lx, y, p);
                    mimg.SetPixel(rx, y, p);
                }
            }

            //load mirror image in picturebox2
            pictureBox_resim.Image = mimg;


        }

        // GRAY SCALE
        private void toolStripButton_grayScale_Click(object sender, EventArgs e)
        {
            // bu kodlarda yapılan her pixel'in üzerindeki 3 kanal'ın aritmetik ortalaması alınarak yerine yazılmasıdır.

            // IMP: teknik bilgi: 8 bitlik bir renk yapısı üzerinde çalışıyoruz. 
            // dolayısıyla aslında her bir renk aslında 1 Byte boyutunda bir veridir.

            int i, j;
            Color renk;//Color sınıfından bir renk nesne tanımlıyoruz.
            Bitmap bmp = new Bitmap(pictureBox_resim.Image);

            for (i = 0; i <= bmp.Width - 1; i++)//dikey olarak görüntümüzü tarıyoruz.
            {
                for (j = 0; j <= bmp.Height - 1; j++)//yatay olarak görüntümüzü tarıyoruz. 
                {
                    renk = bmp.GetPixel(i, j);
                    renk = Color.FromArgb((byte)((renk.R + renk.G + renk.B) / 3), (byte)((renk.R + renk.G + renk.B) / 3), (byte)((renk.R + renk.G + renk.B) / 3));
                    bmp.SetPixel(i, j, renk);
                }
            }
            pictureBox_resim.Image = bmp;

        }

        // HISTOGRAM
        private void toolStripButton_histogram_Click(object sender, EventArgs e)
        {
            // historamda eldeki bir sabit ile , her bir renk kanalın ait olan değerler toplanıyor 
            // ve gerekli işlemlerin sonucunda yeni pixel değerlerin yerlerine yazılıyor.

            Bitmap renderedImage = new Bitmap(pictureBox_resim.Image);

            // gerekli tanımlamalar:
            uint pixels = (uint)renderedImage.Height * (uint)renderedImage.Width;
            decimal Const = 255 / (decimal)pixels;

            int x, y, R, G, B;

            // renklerin geçme sayılarını tutataacak  olan integer dizisi tanımlanmata:
            int[] HistogramRed2 = new int[256];
            int[] HistogramGreen2 = new int[256];
            int[] HistogramBlue2 = new int[256];


            // her bi renk-kanalına ait olan değerler dizide gerekli yerleree yazılmakta:
            for (var i = 0; i < renderedImage.Width; i++)
            {
                for (var j = 0; j < renderedImage.Height; j++)
                {
                    var piksel = renderedImage.GetPixel(i, j);

                    HistogramRed2[(int)piksel.R]++;
                    HistogramGreen2[(int)piksel.G]++;
                    HistogramBlue2[(int)piksel.B]++;

                }
            }

            // değerlere gerekli işlemler yapılıyor ve yeni bir dizide saklanıyor:
            int[] cdfR = HistogramRed2;
            int[] cdfG = HistogramGreen2;
            int[] cdfB = HistogramBlue2;

            for (int r = 1; r <= 255; r++)
            {
                cdfR[r] = cdfR[r] + cdfR[r - 1];
                cdfG[r] = cdfG[r] + cdfG[r - 1];
                cdfB[r] = cdfB[r] + cdfB[r - 1];
            }

            // en son elde edilen dizideki elemanlar her bir pixel'deki karşılıkları bulunan sabitle çarpılıyor, yerine yazılıyor:
            for (y = 0; y < renderedImage.Height; y++)
            {
                for (x = 0; x < renderedImage.Width; x++)
                {
                    Color pixelColor = renderedImage.GetPixel(x, y);

                    R = (int)((decimal)cdfR[pixelColor.R] * Const);
                    G = (int)((decimal)cdfG[pixelColor.G] * Const);
                    B = (int)((decimal)cdfB[pixelColor.B] * Const);

                    Color newColor = Color.FromArgb(R, G, B);
                    renderedImage.SetPixel(x, y, newColor);
                }
            }

            // pictureBox'da gösterme işlemi:
            pictureBox_resim.Image = renderedImage;

        }

        // ROTATE 90 Degree
        private void toolStripButton_rotateClockwise_Click(object sender, EventArgs e)
        {
            // resim alınıyor bitmap olarak 
            Bitmap bmp = new Bitmap(pictureBox_resim.Image);

            // gerekli tanımlamalar:
            float angle = 90;

            float alpha = angle;
            float gamma = 90;
            float beta = 180 - angle - gamma;

            // gerekli hesaplamalar:
            float c1 = bmp.Height;
            float a1 = (float)(c1 * Math.Sin(alpha * Math.PI / 180) / Math.Sin(gamma * Math.PI / 180));
            float b1 = (float)(c1 * Math.Sin(beta * Math.PI / 180) / Math.Sin(gamma * Math.PI / 180));

            float c2 = bmp.Width;
            float a2 = (float)(c2 * Math.Sin(alpha * Math.PI / 180) / Math.Sin(gamma * Math.PI / 180));
            float b2 = (float)(c2 * Math.Sin(beta * Math.PI / 180) / Math.Sin(gamma * Math.PI / 180));

            // dönme sonucunda elde edilecek olan resmin yerleştirileği yeni bitmap nesnesinin boyutları hesaplanıyor:
            int width = Convert.ToInt32(b2 + a1);
            int height = Convert.ToInt32(b1 + a2);

            // graphic nesnesinin yardımı ile gerekli açıda resmimiz döndürülmektedir:
            Bitmap rotatedImage = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(rotatedImage);
            g.TranslateTransform(rotatedImage.Width / 2, rotatedImage.Height / 2); //set the rotation point as the center into the matrix
            g.RotateTransform(angle); //rotate
            g.TranslateTransform(-rotatedImage.Width / 2, -rotatedImage.Height / 2); //restore rotation point into the matrix
            g.DrawImage(bmp, new Point((width - bmp.Width), (height - bmp.Height))); //draw the image on the new bitmap

            // elde edilen döndürülmüş resim pictureBox'ta gösteriliyor:
            pictureBox_resim.Image = rotatedImage;
        }

        // ROTATE -90 Degree
        private void toolStripButton_rotateNClockwise_Click(object sender, EventArgs e)
        {
            // üstteki ile aynı, sadece veriken sabitler farklı.
            
            Bitmap bmp = new Bitmap(pictureBox_resim.Image);
            float angle = 270;
            
            float alpha = angle;
            float gamma = 90;
            float beta = 180 - angle - gamma;

            float c1 = bmp.Height;
            float a1 = (float)(c1 * Math.Sin(alpha * Math.PI / 180) / Math.Sin(gamma * Math.PI / 180));
            float b1 = (float)(c1 * Math.Sin(beta * Math.PI / 180) / Math.Sin(gamma * Math.PI / 180));

            float c2 = bmp.Width;
            float a2 = (float)(c2 * Math.Sin(alpha * Math.PI / 180) / Math.Sin(gamma * Math.PI / 180));
            float b2 = (float)(c2 * Math.Sin(beta * Math.PI / 180) / Math.Sin(gamma * Math.PI / 180));

            int width = Convert.ToInt32(b2 + a1);
            int height = Convert.ToInt32(b1 + a2);

            Bitmap rotatedImage = new Bitmap(Math.Abs(width * 2), Math.Abs(height * 2));
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(rotatedImage.Width / 2, rotatedImage.Height / 2); //set the rotation point as the center into the matrix
                g.RotateTransform(angle); //rotate
                g.TranslateTransform(-rotatedImage.Width / 2, -rotatedImage.Height / 2); //restore rotation point into the matrix
                g.DrawImage(bmp, new Point((width + bmp.Width) / 2, (height + bmp.Height) / 2)); //draw the image on the new bitmap
            }

            pictureBox_resim.Image = rotatedImage;

        }

        // SCALING
        private void toolStripButton_scale_Click(object sender, EventArgs e)
        {
            // eğer veri giriş kutuları(textbox'lar)'daki veriler tutarlı değil ise:
            if (toolStripTextBox_height.Text.Length == 0 || toolStripTextBox_width.Text.Length == 0)
            {
                MessageBox.Show("Lütfen geçerli bir değer giriniz...");
            }
            else
            {
                // bir image nesnesi oluşturuluor: fakat dikkat edelim; Clone metodu ile var olanın bir kopyası alınıyor:
                Image image = (Image)pictureBox_resim.Image.Clone();

                // resmin yeni boyutları kullanıcıdan alınıyor:
                float constWidth = Convert.ToInt32(toolStripTextBox_width.Text);
                float constHeight = Convert.ToInt32(toolStripTextBox_height.Text);

                // iki sabit hesaplanıyor.
                float nPercent = ((float)constWidth / image.Width);
                float lPercent = ((float)constHeight / image.Height);
                
                int sourceWidth = image.Width;
                int sourceHeight = image.Height;
                int sourceX = 0;
                int sourceY = 0;

                int destX = 0;
                int destY = 0;
                
                // yeni resme ait olacak uzunluklar belirleniyor:
                int destWidth = (int)(sourceWidth * nPercent);
                int destHeight = (int)(sourceHeight * lPercent);

                // yeni resim için istenilen özelliklere ait bir bitmap nesnesi oluşturuluyor:
                Bitmap bmPhoto = new Bitmap(destWidth, destHeight, PixelFormat.Format24bppRgb);
                bmPhoto.SetResolution(image.HorizontalResolution, image.VerticalResolution);

                // Graphics sınıfının yardımı ile orijinal resim yeniden boyutlandırılarak yeni bitmap'e aktarılıyor:
                Graphics grPhoto = Graphics.FromImage(bmPhoto);
                grPhoto.DrawImage(image,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);
                image = bmPhoto;
                grPhoto.Dispose();

                // yeni resim pictureboc'ta gösteriliyor:
                pictureBox_resim.Image = image;
            }


        }

        // RED CHANNEL
        private void toolStripButton_RedChannel_Click(object sender, EventArgs e)
        {
            // bu kısımda sadece her pixel'deki kanallardan sadece kırmızı kanal aynen bırakılıyor, geri kalanları 0'lanıyor:

            Bitmap renderedImage = new Bitmap(pictureBox_resim.Image);

            for (int y = 0; y < renderedImage.Height; y++)
            {
                for (int x = 0; x < renderedImage.Width; x++)
                {
                    Color pixelColor = renderedImage.GetPixel(x, y);

                    Color new_Color = Color.FromArgb(pixelColor.R, 0, 0);
                    renderedImage.SetPixel(x, y, new_Color);
                }
            }

            pictureBox_resim.Image = renderedImage;
        }

        // GREEEN CHANNEL
        private void toolStripButton_GreenChannel_Click(object sender, EventArgs e)
        {
            // bu kısımda sadece her pixel'deki kanallardan sadece green kanal aynen bırakılıyor, geri kalanları 0'lanıyor:

            Bitmap renderedImage = new Bitmap(pictureBox_resim.Image);

            for (int y = 0; y < renderedImage.Height; y++)
            {
                for (int x = 0; x < renderedImage.Width; x++)
                {
                    Color pixelColor = renderedImage.GetPixel(x, y);

                    Color new_Color = Color.FromArgb(0, pixelColor.G, 0);
                    renderedImage.SetPixel(x, y, new_Color);
                }
            }

            pictureBox_resim.Image = renderedImage;
        }

        // BLUE CHANNEL
        private void toolStripButton_BlueChannel_Click(object sender, EventArgs e)
        {
            // bu kısımda sadece her pixel'deki kanallardan sadece blue kanal aynen bırakılıyor, geri kalanları 0'lanıyor:

            Bitmap renderedImage = new Bitmap(pictureBox_resim.Image);

            for (int y = 0; y < renderedImage.Height; y++)
            {
                for (int x = 0; x < renderedImage.Width; x++)
                {
                    Color pixelColor = renderedImage.GetPixel(x, y);

                    Color new_Color = Color.FromArgb(0, 0, pixelColor.B);
                    renderedImage.SetPixel(x, y, new_Color);
                }
            }

            pictureBox_resim.Image = renderedImage;
        }

       

        private void toolStripButton_information_Click(object sender, EventArgs e)
        {
            MessageBox.Show("140201050 Çiller Taş" + Environment.NewLine + "140201034 Tuğba Seven", "GRUP ÜYELERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }

}


// just for new commit