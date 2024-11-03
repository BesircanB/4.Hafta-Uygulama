using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urun
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun("Laptop", 30000);
            urun1.Indirim = 20;

            Console.WriteLine("Ürün: " + urun1.Ad);
            Console.WriteLine("Normal Fiyat: " + urun1.Fiyat);
            Console.WriteLine("İndirim Oranı: %" + urun1.Indirim);
            Console.WriteLine("İndirimli Fiyat: " + urun1.IndirimliFiyat());
            Console.ReadLine();

        }
    }
    class Urun
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        private decimal indirim;

        public decimal Indirim
        {
            get { return indirim; }
            set
            {
                if (value >= 0 && value <= 50)
                    indirim = value;
            }
        }

        public Urun(string ad, decimal fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
            indirim = 0;
        }

        public decimal IndirimliFiyat()
        {
            return Fiyat - (Fiyat * indirim / 100);
        }
    }
}
