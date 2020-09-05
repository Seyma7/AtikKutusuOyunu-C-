using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace B191210029ndpprj
{
    //Atıkların kalıtım alacağı özellikler ara yüzde tasarlandı.
    public interface IAtik
    {
        int Hacim { get; }
        Image Image { get; }
        string Ad { get; }
    }


    //Arayüzün özellikleri get,set metodlarıyla tanımlandı.
    public interface IDolabilen
    {
        int Kapasite { get; set; }
        int DoluHacim { get; }
        int DolulukOrani { get; }
    }


    //IAtikKutusu IDolabilen ara yüzünden kalıtım aldı, yeni özellik ve fonksiyonlar da yazıldı.
    public interface IAtikKutusu : IDolabilen
    {
        int BosaltmaPuani { get; }
        bool Ekle(IAtik atik);
        bool Bosalt();
    }
}
