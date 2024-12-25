using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeProje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankaHesabi bankaHesabi1 = new BankaHesabi("123456", 500);
            BankaHesabi bankaHesabi2 = new BankaHesabi("789101", 1000);

            Console.WriteLine("Banka Hesabi 1 ");
            bankaHesabi1.ParaYatir(200);
            bankaHesabi1.ParaCek(100);

            Console.WriteLine("Banka Hesabi 2");
            bankaHesabi2.ParaCek(1200);
            bankaHesabi2.ParaCek(500);


            Console.WriteLine("\nSon Bakiyeler:");
            Console.WriteLine($"Hesap 1 Bakiye: {bankaHesabi1.GetBakiye()} TL");
            Console.WriteLine($"Hesap 2 Bakiye: {bankaHesabi2.GetBakiye()} TL");

        }
    }
}
