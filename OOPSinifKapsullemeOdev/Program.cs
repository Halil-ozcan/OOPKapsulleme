using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSinifKapsullemeOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();

            musteri.TCKimlikNumarasi = "12345678901";
            string TC = musteri.TCKimlikNumarasi;
        }
    }
}
