using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSinifKapsullemeOdev
{
    internal class Musteri
    {
        private string _tckimliknumarasi;

        public string TCKimlikNumarasi
        {
             get { return _tckimliknumarasi.Substring(0,3);}

            set
            {
                if(value.Length == 11)
                {
                    bool bayrak = false;
                    for(int i = 0; i<value.Length; i++)
                    {
                        bool karalterKontrol = char.IsNumber(value[i]);

                        if(karalterKontrol)
                        {
                            //Sayısal deger demektir.
                        }
                        else
                        {
                            bayrak = true;
                            break;
                        }
                    }
                    if(bayrak)
                    {
                        Console.WriteLine("TC Kimlik Numarasi içerisindeki degerler sayısal olmalıdır.");
                    }
                    else
                    {
                        this._tckimliknumarasi = value;
                    }
                }
                else
                {
                    Console.WriteLine("TC Kimlik Numarası 11 Haneli Olmaldır");
                }
            }
        }
    }
}
