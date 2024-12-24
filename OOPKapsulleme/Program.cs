using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPKapsulleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Musteri musteri = new Musteri();
            //musteri.id = 1;
            //musteri.isim = "Halil";
            //musteri.soyisim = "Özcan";


            // field değer ataması yapılmasın ama değer okunabilsin.
            // field değer ataması yapsın ama değer okuyamasın.
            // field değer ataması yapılsın ama ilk 4hanesi okunsun.

            musteri.emailAddress = "Halil@gmail.com";

            Console.WriteLine(musteri.EmailAddress);


            // 1. field deger ataması yapılamsın ama deger okunabilsin.
            Console.WriteLine("Musteri ID Degeri : " + musteri.ID.ToString());
            
        }
    }
}
