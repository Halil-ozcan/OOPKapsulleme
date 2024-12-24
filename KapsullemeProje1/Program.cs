using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeProje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri kisi1 = new Musteri("Ahmet", "Yılmaz", 25);
            Musteri kisi2 = new Musteri("Ayşe", "Kara", -5); 
            Musteri kisi3 = new Musteri("Mehmet", "Demir", 45);

            Console.WriteLine($"Ad-Soyad: {kisi1.GetAdSoyad()}, Yaş: {kisi1.GetYas()}");
            Console.WriteLine($"Ad-Soyad: {kisi2.GetAdSoyad()}, Yaş: {kisi2.GetYas()}");
            Console.WriteLine($"Ad-Soyad: {kisi3.GetAdSoyad()}, Yaş: {kisi3.GetYas()}");


            Console.WriteLine("\nAyşe'nin yaşını güncellemek istiyoruz...");
            kisi2.SetYas(30);
            Console.WriteLine($"Ad-Soyad: {kisi2.GetAdSoyad()}, Güncel Yaş: {kisi2.GetYas()}");



        }
    }
}
