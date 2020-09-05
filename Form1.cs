/*****************************************************************************************************************************************************
 * ************************************           SAKARYA ÜNİVERSİTESİ BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ 
 * ************************                                         BİLGİSAYAR MÜHENDİSLİĞİ 
 * *********************                        NESNEYE DAYALI PROGRAMLAMA BAHAR DÖNEMİ PROJESİ : ATIK TOPLAMA KUTUSU
 * *********************                                         ÖĞRENCİ : ŞEYMA GÖL 
 * *********************                                         NUMARASI : B191210029
 * ************************                                      1-C (1.ÖĞRETİM)
 * *************************************
 * ******************************************************************************************************************************************************/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace B191210029ndpprj
{
    public partial class Form1 : Form
    {
        //Atıklar için nesneler oluşturuldu.
        Domates domates = new Domates();
        Salatalik salatalik = new Salatalik();
        Bardak bardak = new Bardak();
        CamSise camSise = new CamSise();
        Gazete gazete = new Gazete();
        Dergi dergi = new Dergi();
        KolaKutusu kolaKutusu = new KolaKutusu();
        SalcaKutusu salcaKutusu = new SalcaKutusu();


        //IAtik interfacesi kullanılarak atıkların classlarından nesneler oluşturuldu.
        IAtik atik = new Domates();
        IAtik atik1 = new Salatalik();
        IAtik atik2 = new Bardak();
        IAtik atik3 = new CamSise();
        IAtik atik4 = new Gazete();
        IAtik atik5 = new Dergi();
        IAtik atik6 = new KolaKutusu();
        IAtik atik7 = new SalcaKutusu();


        //IAtikKutusu interfacesi kullanılarak atık kutularına nesneler oluşturuldu.
        OrganikAtikKutusu organikAtikKutusu = new OrganikAtikKutusu();
        IAtikKutusu atikK = new OrganikAtikKutusu();

        CamAtikKutusu camAtikKutusu = new CamAtikKutusu();
        IAtikKutusu atikK1 = new CamAtikKutusu();

        MetalAtikKutusu metalAtikKutusu = new MetalAtikKutusu();
        IAtikKutusu atikK2 = new MetalAtikKutusu();

        KagitAtikKutusu kagitAtikKutusu = new KagitAtikKutusu();
        IAtikKutusu atikK3 = new KagitAtikKutusu();


        //Atıkları 
        public static List<IAtik> atikList = new List<IAtik>();
        ImageList imageList = new ImageList();

        public static int randomSec;


        //bool Ekle() fonksiyonuyla koşul konularak : listBoxlara atık adı,hacmi ; progressBara eklenen atığın hacmi ; hacim label3'e puan olarak eklendi.
        public void Eklee(IAtik atik, Image ımage, ListBox listBox, ProgressBar progressBar)
        {

            listBox.Items.Add(atik.Ad + "(" + atik.Hacim.ToString() + ")");
            progressBar.Value += atik.Hacim;
            label3.Text = (int.Parse(label3.Text) + atik.Hacim).ToString();

        }


        //Atık kutularındaki bool tipi Bosalt() fonksiyonuyla birlikte puan,süre ekleme ve listbox,progresbarr boşaltma görevi.
        public void Bosaltt(ListBox listBox, ProgressBar progressBar)
        {
            listBox.Items.Clear();
            progressBar.Value = 0;
            sayi += 3;
        }


        //Eski verileri sildi.Oyunu ilk baştaki haline döndürdü.
        public void OyunuTemizle()
        {
            label2.Text = 60.ToString();
            sayi = 60;
            label3.Text = 0 + "";
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;
        }


        
        public void ResimEkle()
        {
            //Resimler klasörden eklendi.
            Image _domates = Image.FromFile("image5.jpg");
            Image _salatalik = Image.FromFile("image6.jpg");
            Image _camSise = Image.FromFile("image1.jpg");
            Image _bardak = Image.FromFile("image2.jpg");
            Image _gazete = Image.FromFile("image3.jpg");
            Image _dergi = Image.FromFile("image4.jpg");
            Image _kolaKutusu = Image.FromFile("image7.jpg");
            Image _salcaKutusu = Image.FromFile("image8.jpg");


            //Klasörden çekilen resimler imageListe eklendi.
            imageList.Images.Add(_domates);
            imageList.Images.Add(_salatalik);
            imageList.Images.Add(_bardak);
            imageList.Images.Add(_camSise);
            imageList.Images.Add(_gazete);
            imageList.Images.Add(_dergi);
            imageList.Images.Add(_kolaKutusu);
            imageList.Images.Add(_salcaKutusu);


            //Bulanıklığı önlemek için imageList boyutları pictureBoxtakine eşitlendi.
            imageList.ImageSize = new Size(200, 167);
            imageList.ImageSize = new Size(200, 167);


            //En yukarıda atık listesi oluşturuldu burada da ekleme yapıldı.
            //Eklemeler
            atikList.Add(atik);
            atikList.Add(atik1);
            atikList.Add(atik2);
            atikList.Add(atik3);
            atikList.Add(atik4);
            atikList.Add(atik5);
            atikList.Add(atik6);
            atikList.Add(atik7);


            //Görseller randomla rastgele pictureBox'a yazdırıldı.
            Random random = new Random();
            randomSec = random.Next(0, 8);

            pictureBox1.Image = imageList.Images[randomSec];
        }



        //Yeni oyun başladığında tüm butonlar açılsın diye.
        public void ButonAc()
        {
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Oyun ekrana geldiğinde ekranda çıkacak olan puan,süre yazıldı.
            label2.Text = 60.ToString();
            label3.Text = 0.ToString();
        }


        //Yeni oyunu başlatacak.
        private void button1_Click(object sender, EventArgs e)
        {
            OyunuTemizle();
            timer1.Enabled = true;
            ButonAc();
            //Atık listesini ve resim listesini boşalttık
            atikList.Clear();
            imageList.Images.Clear();
            ResimEkle();

        }


        //Timerı çalıştıracak.
        int sayi = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            if (sayi >= 0)
            {
                int sayac = sayi--;
                label2.Text = sayac.ToString();
            }
            else
            {
                timer1.Stop();
                //Süre bitti ve bütün butonları disabled yaptık
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                MessageBox.Show("Oyun Bitti\nPuanınız : " + label3.Text);
            }
        }




        //Organik atık kutusuna ekleyecek.
        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;

            if (atikK.Ekle(atikList[randomSec]))
            {

                //Domates
                if (atikList[randomSec].Ad == atik.Ad)
                {
                    Eklee(atik, Image.FromFile("image5.jpg"), listBox3, progressBar1);
                }
                //Salatalık
                if (atikList[randomSec].Ad == atik1.Ad)
                {
                    Eklee(atik1, Image.FromFile("image6.jpg"), listBox3, progressBar1);
                }

            }

            ResimEkle();
        }




        //Organik atık kutusunu boşaltacak.
        private void button10_Click(object sender, EventArgs e)
        {

            if (atikK.Bosalt() == true)
            {
                Bosaltt(listBox3, progressBar1);
                label3.Text = (int.Parse(label3.Text) + atikK.BosaltmaPuani).ToString();
            }

        }



        //Kağıt atık kutusuna ekleyecek.
        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;

            //Eğer pictureBoxta gösterilen resim Gazete veya Dergiden birine eşitse
            if (atikK3.Ekle(atikList[randomSec]) == true)
            {

                if (atikList[randomSec].Ad == atik4.Ad)
                {
                    //Gazete
                    Eklee(atik4, Image.FromFile("image3.jpg"), listBox4, progressBar2);
                }
                if (atikList[randomSec].Ad == atik5.Ad)
                {
                    //Dergi
                    Eklee(atik5, Image.FromFile("image4.jpg"), listBox4, progressBar2);
                }

            }

            ResimEkle();

        }


        //Kağıt atık kutusunu boşaltacak.
        private void button7_Click(object sender, EventArgs e)
        {
            if (atikK3.Bosalt() == true)
            {
                Bosaltt(listBox4, progressBar2);
                label3.Text = (int.Parse(label3.Text) + atikK3.BosaltmaPuani).ToString();
            }

        }




        //Cam atık kutusuna ekleyecek.
        private void button11_Click(object sender, EventArgs e)
        {
            button11.Enabled = true;

            //Eğer pictureBoxta gösterilen resim Bardak veya Cam şişeden birine eşitse
            if (atikK1.Ekle(atikList[randomSec]))
            {

                if (atikList[randomSec].Ad == atik2.Ad)
                {

                    //Bardak
                    Eklee(atik2, Image.FromFile("image2.jpg"), listBox5, progressBar3);
                }
                else if (atikList[randomSec].Ad == atik3.Ad)
                {

                    //Cam Şişe
                    Eklee(atik3, Image.FromFile("image1.jpg"), listBox5, progressBar3);
                }

            }

            ResimEkle();

        }



        //Cam atık kutusunu boşaltacak.
        private void button9_Click(object sender, EventArgs e)
        {
            if (atikK1.Bosalt() == true)
            {
                Bosaltt(listBox5, progressBar3);
                label3.Text = (int.Parse(label3.Text) + atikK1.BosaltmaPuani).ToString();
            }

        }



        //Metal atık kutusuna ekleyecek.
        private void button13_Click(object sender, EventArgs e)
        {
            button13.Enabled = true;

            if (atikK2.Ekle(atikList[randomSec]) == true)
            {
                //Eğer pictureBoxta gösterilen resim Kola kutusu veya Salça kutusundan birine eşitse
                if (atikList[randomSec].Ad == atik6.Ad)
                {
                    //Kola Kutusu
                    Eklee(atik6, Image.FromFile("image7.jpg"), listBox6, progressBar4);
                }
                else if (atikList[randomSec].Ad == atik7.Ad)
                {
                    //Salça kutusu
                    Eklee(atik7, Image.FromFile("image8.jpg"), listBox6, progressBar4);
                }

            }

            ResimEkle();

        }


        //Metal atık kutusunu boşaltacak.
        private void button12_Click(object sender, EventArgs e)
        {
            if (atikK2.Bosalt() == true)
            {
                Bosaltt(listBox6, progressBar4);
                label3.Text = (int.Parse(label3.Text) + atikK2.BosaltmaPuani).ToString();
            }

        }

        //Çıkış yapacak.
        private void button4_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

    }
}
