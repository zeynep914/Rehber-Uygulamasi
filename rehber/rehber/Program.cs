/***********************************************************************
 **                        SAKARYA ÜNİVERSİTESİ                       **
 **               BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ           **
 **                BİLİŞİM SİSTEMELRİ MÜHENDİSLİĞİ BÖLÜMÜ             **
 **                  NESNEYE DAYALI PROGRAMLAMA DERSİ                 **
 **                       2019-2020 GÜZ DÖNEMİ                        **
 **                                                                   ** 
 **                                                                   **
 **                                                                   **
 **                                                                   **
 **         ÖDEV NUMARASI..............: 2                            ** 
 **         ÖĞRENCİ ADI................:ZEYNEP UNGURLU                **
 **         ÖĞRENCİ NUMARASI...........:B181200009                    **
 **         DERSİN ALINDIĞI GRUP.......:                              ** 
 **                                                                   **
 **                                                                   **
 **********************************************************************/




using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rehber
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim;
            Telefon T1 = new Telefon();    //Telefon ve kişiler classlarının özelliklerini kullanabilmek için 
            kisiler K1 = new kisiler();    //classların nesnelerini oluşturuyoruz.

        AnaMenu:
            Console.WriteLine(" 1.Kişi Ekle.\n 2.Kişi Bul. \n 3.Tüm kişileri Görüntüle. \n 4.Kişi Sil. \n 5.Tüm kişileri Sil. \n 6.Kişi Duzenle. \n 7.Kişi Engelle. \n 8.Toplam Kişi sayısı.\n 9.Çıkış. ");
            Console.Write("\nİstediğiniz işlemi seçin: ");           
            try
            {
                secim = Convert.ToInt32(Console.ReadLine());         // burada try catch mekanizması ile kullanıcı tarafından
            }                                                        // girilen değerin hatalı olması durumunda hatayı ayıklayıp
            catch                                                    // detaylı bir hata mesajı gönderiyoruz.
            {
                Console.Clear();
                Console.WriteLine("Lütfen Doğru Seçim Yapınız");
                System.Threading.Thread.Sleep(1500); 
                goto AnaMenu;
            }
            switch (secim)    //switch case kullanarak kullanıcının seçtiği işlemleri yapıyoruz.
            {
                case 1:

                    Console.Write("Adı giriniz: ");                   
                    T1.isim = Console.ReadLine();                    //telefon classından örneklediğimiz T1 nesnesi aracılığı ile
                    Console.Write("telefon numarasını giriniz: ");   //telefon classındaki isim ve telno fieldlarına atama yapıyoruz.
                    T1.telno = Console.ReadLine(); 

                    T1.kisiEkle(T1);                                    //telefon classında bulunan kisiEkle() metoduna T1 nesnesi için
                    Console.WriteLine("Ana menüye dön. (E/h) \n\n");    //kullanıcıdan aldığımız isim ve telno değerlerini gönderiyoruz.
                    string sec = Console.ReadLine().ToUpper();
                    if (sec == "E")
                    {
                        goto AnaMenu;
                    }
                    break;

                case 2:

                    Console.WriteLine("\n1-İsme Göre Bul \n2-Numaraya Göre Bul\n");
                    Console.Write("Seçiminizi yapınız: ");
                    string secim2 = Console.ReadLine();
                    if (secim2 == "1")
                    {
                        Console.Write("Bulmak istediğiniz kişinin adını giriniz: "); 
                        string isimsorgu = Console.ReadLine();     // bulmak istenilen kişinin ismini kullanıcıdan alıp
                        T1.ismeGoreBul(isimsorgu);                 // telefon classındaki ismeGoreBul() metoduna gönderiyoruz.
                        Console.WriteLine("\nAna menüye dön. (E/h) \n\n");
                        string sec2 = Console.ReadLine().ToUpper();
                        if (sec2 == "E")
                        {
                            goto AnaMenu;
                        }
                        break;
                    }

                    if (secim2 == "2")
                    {
                        Console.Write("Bulmak istediğiniz numarayı giriniz: ");
                        string arananNumara = Console.ReadLine();             // bulmak istenilen kişinin ismini kullanıcıdan alıp
                        T1.numarayaGoreBul(arananNumara);                    // telefon classındaki numarayaGoreBul() metoduna gönderiyoruz.
                        Console.WriteLine("\nAna menüye dön. (E/h) \n\n");
                        string sec2 = Console.ReadLine().ToUpper();
                        if (sec2 == "E")
                        {
                            goto AnaMenu;
                        }
                        break;
                    }
                    break;


                case 3:
                    Console.Write("Kişiler: \n\n");
                    T1.KisileriListele(kisiler.rehber);                 // bütün kişileri listelemek için telefon classındaki 
                    Console.WriteLine("\nAna menüye dön. (E/h) \n\n");  // KisileriListele() metodunu çağırıp, içine kisiler 
                    string sec3 = Console.ReadLine().ToUpper();         // classındaki rehber isimli hashtable'ı gönderiyoruz.
                    if (sec3 == "E")
                    {
                        goto AnaMenu;
                    }
                    break;

                case 4:
                    T1.KisileriListele(kisiler.rehber);           
                    Console.Write("Silmek istediğiniz kişinin ismini giriniz: \n\n");
                    string isim2 = Console.ReadLine();             // silmek istenen ismi kullanıcıdan alıp
                    T1.kisiSil(isim2);                             // telefon classında bulunan kisiSil() metoduna gönderiyoruz.
                    Console.WriteLine("Silme işlemi başarıyla yapıldı.");
                    Console.WriteLine("Ana menüye dön. (E/h) \n\n");
                    string sec4 = Console.ReadLine().ToUpper();
                    if (sec4 == "E")
                    {
                        goto AnaMenu;
                    }
                    break;

                case 5:
                    T1.KisileriListele(kisiler.rehber);
                    Console.Write("Bütün kayıtlar silinecek emin misiniz: (E/h) \n\n");
                    string sec5 = Console.ReadLine().ToUpper();
                    if (sec5 == "E")
                    {
                        kisiler.rehber.Clear();           // kisiler classındaki rehber hashtable'ının tamamı siliniyor. 
                        Console.WriteLine("Bütün kişiler silindi. ");
                        Console.WriteLine("Ana menüye dön. (E/h) \n\n");
                        string sec6 = Console.ReadLine().ToUpper();
                        if (sec6 == "E")
                        {
                            goto AnaMenu;
                        }
                        break;
                    }
                    break;

                case 6:
                    T1.KisileriListele(kisiler.rehber);
                    Console.Write("Düzenlemek istediğiniz kişinin adını giriniz: ");
                    string degisecekIsım = Console.ReadLine();     // duzenlenmek istenen kisinin ismi kullanicidan aliniyor.
                    Console.Write("Yeni ismi giriniz: ");         
                    string yeniIsım = Console.ReadLine();        // duzenlenmek istenen ismin yerine yazılacak isim kullanıcıdan alınıyor.
                    T1.kisiDuzenle(degisecekIsım, yeniIsım);     // bu iki değişken telefon classındaki kisiDuzenle() metoduna yollanıyor.
                    Console.WriteLine("\nDüzenleme Başarılı...\n");
                    Console.WriteLine("Ana menüye dön. (E/h) \n\n");
                    string sec8 = Console.ReadLine().ToUpper();
                    if (sec8 == "E")
                    {
                        goto AnaMenu;
                    }
                    break;
                   
                case 7:
                    T1.KisileriListele(kisiler.rehber);
                    Console.WriteLine("Engellemek istediğiniz kişi adını giriniz.");
                    string engellenenKisi = Console.ReadLine();   // engellenmek istenen kişinin ismi kullanıcıdan alınıyor.
                    T1.kisiEngelle(engellenenKisi);               // telefon classındaki kisiEngelle() metodu çağırılıp içine gönderiliyor.
                    Console.WriteLine("Ana menüye dön. (E/h) \n\n");
                    string sec10 = Console.ReadLine().ToUpper();
                    if (sec10 == "E")
                    {
                        goto AnaMenu;
                    }
                    break;
                    
                case 8:
                    Console.Write("Rehberde kayıtlı toplam kişi sayısı: ");  
                    Console.WriteLine(kisiler.rehber.Count);          // kisiler classındaki rehber hashtable'ı içindeki key value çiftlerinin 
                    Console.WriteLine("Ana menüye dön. (E/h) \n\n");  // toplam sayısı Hashtable.Count() metodu ile hesaplanıp ekrana yazdırılıyor.
                    string sec11 = Console.ReadLine().ToUpper();
                    if (sec11 == "E")
                    {
                        goto AnaMenu;
                    }
                    break;                                  

            }
        }
    }
}
