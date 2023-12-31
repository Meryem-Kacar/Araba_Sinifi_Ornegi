using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace araba_sinifi_ornek_proje
{
    internal class Program
    {
        //araba sınıfından nesne türetilecek
        //oluşan nesne aracılığıyla oluşturduğumuz araba sınıfının niteliklerine ulaşılacak
        //Niteliklere değer ataması gerçekleştirilecek
        static void Main(string[] args)
        {
            //Araba sınıfı verileri
            Araba ar = new Araba();
            ar.marka = "Marka X.";
            ar.hiz = 180;
            ar.model = "2021";
            ar.renk = "Beyaz";

            Console.Write("*****ARABA TANITIM KARTI 1******");
            Console.WriteLine();
            Console.WriteLine("Marka: " + ar.marka);
            Console.WriteLine("Hız: " + ar.hiz);
            Console.WriteLine("Model: " + ar.model);
            Console.WriteLine("Renk: " + ar.renk);
            Console.WriteLine();
            Console.Write("--------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            // müşteri sınıfı verileri
            Musteri m = new Musteri();
            Console.Write("*****MÜŞTERİ BİLGİSİ******");
            m.Name = "Meryem";
            m.surname = "Kaçar";
            m.city = "Zonguldak";
            m.id = 1;

            Console.WriteLine();
            Console.WriteLine("İd: " + m.id);
            Console.WriteLine("Ad: " + m.Name);
            Console.WriteLine("Soyad: " + m.surname);
            Console.WriteLine("Şehir: " + m.city);
            m.Name = "Yusuf Hakan";
            m.surname = "Ege";
            m.city = "Bursa";
            m.id = 2;
            Console.Write("---------------------");
            Console.WriteLine();
            Console.WriteLine("İd: " + m.id);
            Console.WriteLine("Ad: " + m.Name);
            Console.WriteLine("Soyad: " + m.surname);
            Console.WriteLine("Şehir: " + m.city);
            Console.WriteLine("--------------");
            //klavyeden veri girişi
            Musteri mu = new Musteri();
            Console.Write("ID Değerini Giriniz: ");
            mu.id=Convert.ToInt32(Console.ReadLine());
            Console.Write("Adınız: ");
            mu.Name =Console.ReadLine();
            Console.Write("Soyadınız: ");
            mu.Surname =Console.ReadLine();
            Console.Write("Şehriniz: ");
            mu.city =Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(mu.id + " " + mu.Name + " " + mu.Surname + " " + mu.city);


            Console.Read();

        }
    }
}
