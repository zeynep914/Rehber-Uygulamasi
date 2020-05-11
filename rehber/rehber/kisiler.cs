using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rehber
{
    public class kisiler:Telefon    //Telefon classından miras alınıyor.
    {
        public static Hashtable rehber = new Hashtable();   // hashtable'ımıza her yerden class ismi ile ulaşabilmek için 
                                                            // static ve public olarak tanımlıyoruz.
        public kisiler()
        {
            rehber.Add("05436573475", "Mert Güldür");         // yapıcı metot(constructor) oluşturarak içine 
            rehber.Add("05445670989", "Mahmut Gürcan ");      // Add() metodu ile örnek isimler ekliyoruz.
            rehber.Add("05343537284", "Gizem Ertekin");
            rehber.Add("05344505169", "Halis Palabıyık");
            rehber.Add("02123456573", "Tolga Özkahya");
            rehber.Add("05541235641", "Cüneyt Aydınus");
            rehber.Add("05436456455", "Ahmet Yeter");
            rehber.Add("05436456459", "Selman Sönmez ");
            rehber.Add("05356464545", "Can Hızal");
            rehber.Add("05345839679", "Hüseyin Ungurlu");
            rehber.Add("02128796789", "Zeynep Erdem");
            rehber.Add("05545875678", "Esra Çelik");
        }
    }
}
