using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKapsulleme
{
    internal class Musteri
    {

        public Musteri() 
        {
            this.id = IDUret();
        }


        // Bunlar Class => Field olarak geçer.
        int id;
        public int ID
        {
            get
            {
                return this.id;
            }

            private set // sadece değer okunabilsin değer ataması yapılmasın diye private yapıyoruz.
            {
                this.id = value;
            }
        }
        public string isim;
        public string soyisim;


        public string emailAddress;

        public string EmailAddress
        {
            //get; // database veya farklı bir veri kaynagı Classı  çağıran programcıya datayı gösterdiğimiz kısım.
            //set; // dış dünyadan alinan datanın içeride private olarak saklanan field içerisine deger atandığı kısım.

            set
            {
                this.emailAddress = value;
            }

            get
            { 
                return this.emailAddress;
            }
        }

        private int IDUret()
        {
            Random rnd = new Random();
            return rnd.Next(10000,90000);
        }
    }
}
