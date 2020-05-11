using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rehber
{
    public class Telefon     // Her yerden erişebilmek için classımızı public olarak işaretliyoruz.
    {
        public string isim, isim2;   
        public string telno;

        public void kisiEkle(Telefon tel)
        {
            kisiler.rehber.Add(tel.telno, tel.isim);       // program.cs de kullanıcıdan almış olduğumuz isim ve telno değerlerini
            Console.WriteLine("Kişi başarıyla eklendi.");  // kisiler classındaki rehber hashtable'ına Add() metodu ile ekliyoruz.
        }

        public void ismeGoreBul(string isimSorgu)
        {
            string temp = null;

            if (kisiler.rehber.ContainsValue(isimSorgu))    // program.cs den gelen, bulmak istenen kişinin ismini Contains() metodu ile
            {                                               // rehber hashtable'ı içerisinde olup olmadığını kontrol ediyoruz.

                foreach (DictionaryEntry entry in kisiler.rehber)  // bu kişi ismini foreach döngüsü ile hashtable içinde arıyoruz.
                {
                    if (isimSorgu == entry.Value.ToString())  // eğer isim(Value)'nun stringe çevrilmiş hali hashtable içinde bulunursa 
                    {
                        temp = entry.Key.ToString();          // null olarak işaretlediğimiz temp geçici fieldına o entry'nin 
                    }                                      // key değerini atıyoruz.
                }
                Console.WriteLine("Aradığınız isim rehberde mevcuttur.\n");
                Console.WriteLine("{0}  -  {1}  \n", temp, isimSorgu);      // key değerini atadığımız temp fieldı ve kullanıcıdan gelen
            }                                                               // isimSorgu fieldını ekrana yazdırıyoruz.
        }  

        public void numarayaGoreBul(string numara)
        {
             string temp = null;

            if (kisiler.rehber.ContainsKey(numara))       // program.cs den gelen, bulmak istenen kişinin numarasının Contains() metodu 
            {                                             // ile rehber hashtable'ı içerisinde olup olmadığını kontrol ediyoruz.

                foreach (DictionaryEntry entry in kisiler.rehber)   // numarayı(key) foreach döngüsü ile hashtable içinde arıyoruz.
                {
                    if (numara == entry.Key.ToString())      // eğer numara(key) hashtable içinde bulunursa 
                    {
                        temp = entry.Value.ToString();       // null olarak işaretlediğimiz temp geçici fieldına o entry'nin 
                    }                                     // value değerini atıyoruz.
                }
                Console.WriteLine("Aradığınız numara rehberde mevcuttur.\n");  
                Console.WriteLine("Aradığınız Numaranın sahibi - {0}\n", temp);  // value'yu atadığımız temp fieldını ekrana yazdırıyoruz.
            }
        }

        public void KisileriListele(Hashtable kisiHash)
        {
            int i = 1;
            foreach (DictionaryEntry entry in kisiHash)      //foreach döngüsü ile hashtable içindeki tüm key ve value'ları listeliyoruz.
            {
                Console.WriteLine("{0}. {1}  -  {2}", i, entry.Value, entry.Key);
                i++;
            }
        }

        internal void kisiSil(string silinecekisim)
        {

            string temp = null;

            if (kisiler.rehber.ContainsValue(silinecekisim))   //silinecek kişi ismi hashtable içinde aranıyor 
            {

                foreach (DictionaryEntry entry in kisiler.rehber)
                {
                    if (silinecekisim == entry.Value.ToString())   
                    {
                        temp = entry.Key.ToString();    // ve bu isim(Value) bulunursa key değeri temp'e atanıyor. 
                    }
                }

                kisiler.rehber.Remove(temp);   // Remove() metodu ile bu ismin bulunduğu key ve value değeri hashtable içinden siliniyor.
            }
        }

        internal void kisiDuzenle(string degisecekIsım, string yeniIsım)   // program.cs den gönderilen iki parametre alınıyor.
        {

            string temp = null;

            if (kisiler.rehber.ContainsValue(degisecekIsım))    // değişmek istenen isim hashtable içinde kontrol ediliyor. 
            {

                foreach (DictionaryEntry entry in kisiler.rehber)
                {
                    if (degisecekIsım == entry.Value.ToString())  
                    {
                        temp = entry.Key.ToString();               // eğer bulunursa bu ismin bulunduğu yerin key değeri temp'e atanıyor.
                    }
                }
                kisiler.rehber[temp] = yeniIsım;          // yeni isim de rehber hashtable'ı içindeki eski ismin yerine atanıyor.
         
            }
        }   

        internal void kisiEngelle(string engellenecekIsım)   // program.cs den gönderilen engellenecekKisi parmetre olarak alınıyor.
        {

            string temp = null;

            if (kisiler.rehber.ContainsValue(engellenecekIsım))     // engellenmek istenen isim(value) hashtable içinde kontrol ediliyor. 
            {

                foreach (DictionaryEntry entry in kisiler.rehber)
                {
                    if (engellenecekIsım == entry.Value.ToString())
                    {
                        temp = entry.Key.ToString();               // eğer bulunursa bu ismin bulunduğu yerin key değeri temp'e atanıyor.
                    }
                }
                kisiler.rehber[temp] = engellenecekIsım + " (engellendi) ";    // engellenecek isim yanına (engellendi) eklenip. Hashtable
                Console.WriteLine("{0} kişisi engellendi", engellenecekIsım);  // içinde bulunan engellenmek istenen kişi yerine atanıyor. 
            }                                                                  // Ve bu kişi ekranan yazdırılıyor.
        }
    }
}
