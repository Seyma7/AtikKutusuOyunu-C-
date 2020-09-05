using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace B191210029ndpprj
{//IAtik interfacesini kullanarak her atığın hacmi,resmi,ismi atandı,get metodu kullanıldı.
    class CamSise : IAtik
    {
        private int _hacim = 600;
        public int Hacim
        {
            get { return _hacim; }
        }
        Image _camSise = Image.FromFile("image1.jpg");
        Image IAtik.Image
        {
            get { return _camSise; }
        }
        private string _ad = "Cam Şişe";
        public string Ad
        {
            get { return _ad; }
        }
    }



    class Bardak : IAtik
    {
        private int _hacim = 250;
        public int Hacim
        {
            get { return _hacim; }
        }

        private Image _bardak = Image.FromFile("image2.jpg");
        Image IAtik.Image
        {
            get { return _bardak; }
        }

        private string _ad = "Bardak";
        public string Ad
        {
            get { return _ad; }
        }
    }



    class Gazete : IAtik
    {
        private int _hacim = 250;
        public int Hacim
        {
            get { return _hacim; }
        }

        private Image _gazete = Image.FromFile("image3.jpg");
        Image IAtik.Image
        {
            get { return _gazete; }
        }

        private string _ad = "Gazete";
        public string Ad
        {
            get { return _ad; }
        }
    }



    class Dergi : IAtik
    {
        private int _hacim = 200;
        public int Hacim
        {
            get { return _hacim; }
        }

        private Image _dergi = Image.FromFile("image4.jpg");
        Image IAtik.Image
        {
            get { return _dergi; }
        }

        private string _ad = "Dergi";
        public string Ad
        {
            get { return _ad; }
        }
    }



    class Domates : IAtik
    {
        private int _hacim = 150;
        public int Hacim
        {
            get { return _hacim; }
        }

        private Image _domates = Image.FromFile("image5.jpg");
        Image IAtik.Image
        {
            get { return _domates; }
        }

        private string _ad = "Domates";
        public string Ad
        {
            get { return _ad; }
        }
    }



    class Salatalik : IAtik
    {
        private int _hacim = 120;
        public int Hacim
        {
            get { return _hacim; }
        }

        private Image _salatalik = Image.FromFile("image6.jpg");
        Image IAtik.Image
        {
            get { return _salatalik; }
        }

        private string _ad = "Salatalık";
        public string Ad
        {
            get { return _ad; }
        }
    }



    class KolaKutusu : IAtik
    {
        private int _hacim = 350;
        public int Hacim
        {
            get { return _hacim; }
        }

        private Image _kolaKutusu = Image.FromFile("image7.jpg");
        Image IAtik.Image
        {
            get { return _kolaKutusu; }
        }

        private string _ad = "Kola Kutusu";
        public string Ad
        {
            get { return _ad; }
        }
    }



    class SalcaKutusu : IAtik
    {
        private int _hacim = 550;
        public int Hacim
        {
            get { return _hacim; }
        }

        private Image _salcaKutusu = Image.FromFile("image8.jpg");
        Image IAtik.Image
        {
            get { return _salcaKutusu; }
        }

        private string _ad = "Salça Kutusu";
        public string Ad
        {
            get { return _ad; }
        }
    }

}
