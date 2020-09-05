using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B191210029ndpprj
{
    //IAtikKutusu'ndan kalıtım alarak her atık kutusunun özellikleri atandı.
    class OrganikAtikKutusu : IAtikKutusu
    {
        Domates _domates = new Domates();
        IAtik _atik1 = new Domates();
        Salatalik _salatalik = new Salatalik();
        IAtik _atik2 = new Salatalik();

        private int _kapasite = 700;
        public int Kapasite
        {
            get { return _kapasite; }
            set { _kapasite = value; }
        }

        private int _doluHacim;
        public int DoluHacim
        {
            get
            {
                if (Form1.atikList[Form1.randomSec].Ad == _salatalik.Ad || Form1.atikList[Form1.randomSec].Ad == _domates.Ad)
                {
                    _doluHacim += Form1.atikList[Form1.randomSec].Hacim;
                }
                return _doluHacim;
            }
        }


        public int _dolulukOrani;
        public int DolulukOrani
        {
            get
            {

                _dolulukOrani = (int)(((float)_doluHacim / (float)Kapasite) * 100);
                return _dolulukOrani;
            }
        }

        private int _bosaltmaPuani = 0;
        public int BosaltmaPuani
        {
            get { return _bosaltmaPuani; }
        }

        public bool Ekle(IAtik atik)
        {

            if (atik.Ad == _salatalik.Ad || atik.Ad == _domates.Ad)
            {

                if ((Kapasite - DoluHacim) >= atik.Hacim)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                _doluHacim = 0;
                return true;
            }
            else
            {
                return false;
            }
        }
    }




    class KagitAtikKutusu : IAtikKutusu
    {
        Gazete _gazete = new Gazete();
        IAtik _atik1 = new Gazete();
        Dergi _dergi = new Dergi();
        IAtik _atik2 = new Dergi();

        private int _kapasite = 1200;
        public int Kapasite
        {
            get { return _kapasite; }
            set { _kapasite = value; }
        }

        private int _doluHacim;
        public int DoluHacim
        {
            get
            {
                if (Form1.atikList[Form1.randomSec].Ad == _gazete.Ad || Form1.atikList[Form1.randomSec].Ad == _dergi.Ad)
                {
                    _doluHacim += Form1.atikList[Form1.randomSec].Hacim;
                }
                return _doluHacim;
            }
        }


        private int _dolulukOrani;
        public int DolulukOrani
        {
            get
            {
                _dolulukOrani = (int)(((float)_doluHacim / (float)Kapasite) * 100);
                return _dolulukOrani;
            }
        }

        private int _bosaltmaPuani = 1000;
        public int BosaltmaPuani
        {
            get { return _bosaltmaPuani; }
        }

        public bool Ekle(IAtik atik)
        {

            if (atik.Ad == _gazete.Ad || atik.Ad == _dergi.Ad)
            {

                if ((Kapasite - DoluHacim) >= atik.Hacim)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                _doluHacim = 0;
                return true;
            }
            else
            {
                return false;
            }
        }
    }




    class CamAtikKutusu : IAtikKutusu
    {
        CamSise _camSise = new CamSise();
        IAtik _atik1 = new CamSise();
        Bardak _bardak = new Bardak();
        IAtik _atik2 = new Bardak();

        private int _kapasite = 2200;
        public int Kapasite
        {
            get { return _kapasite; }
            set { _kapasite = value; }
        }

        private int _doluHacim;
        public int DoluHacim
        {
            get
            {

                if (Form1.atikList[Form1.randomSec].Ad == _camSise.Ad || Form1.atikList[Form1.randomSec].Ad == _bardak.Ad)
                {
                    _doluHacim += Form1.atikList[Form1.randomSec].Hacim;
                }

                return _doluHacim;
            }
        }


        private int _dolulukOrani;
        public int DolulukOrani
        {
            get
            {
                _dolulukOrani = (int)(((float)_doluHacim / (float)Kapasite) * 100);
                return _dolulukOrani;
            }
        }

        private int _bosaltmaPuani = 600;
        public int BosaltmaPuani
        {
            get { return _bosaltmaPuani; }
        }

        public bool Ekle(IAtik atik)
        {

            if (atik.Ad == _camSise.Ad || atik.Ad == _bardak.Ad)
            {
                if ((Kapasite - DoluHacim) >= atik.Hacim)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }



        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                _doluHacim = 0;
                return true;
            }
            else
            {
                return false;
            }
        }
    }




    class MetalAtikKutusu : IAtikKutusu
    {
        KolaKutusu _kolaKutusu = new KolaKutusu();
        IAtik _atik1 = new KolaKutusu();
        SalcaKutusu _salcaKutusu = new SalcaKutusu();
        IAtik _atik2 = new SalcaKutusu();

        private int _kapasite = 2300;
        public int Kapasite
        {
            get { return _kapasite; }
            set { _kapasite = value; }
        }

        private int _doluHacim;
        public int DoluHacim
        {
            get
            {
                if (Form1.atikList[Form1.randomSec].Ad == _kolaKutusu.Ad || Form1.atikList[Form1.randomSec].Ad == _salcaKutusu.Ad)
                {
                    _doluHacim += Form1.atikList[Form1.randomSec].Hacim;
                }
                return _doluHacim;
            }
        }


        private int _dolulukOrani;
        public int DolulukOrani
        {
            get
            {
                _dolulukOrani = (int)(((float)_doluHacim / (float)Kapasite) * 100);
                return _dolulukOrani;
            }
        }

        private int _bosaltmaPuani = 800;
        public int BosaltmaPuani
        {
            get { return _bosaltmaPuani; }
        }

        public bool Ekle(IAtik atik)
        {

            if (atik.Ad == _kolaKutusu.Ad || atik.Ad == _salcaKutusu.Ad)
            {
                if ((Kapasite - DoluHacim) >= atik.Hacim)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                _doluHacim = 0;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
