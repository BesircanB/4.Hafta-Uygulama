using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKirala
{
    class Program
    {
        static void Main(string[] args)
        {
            KiralikArac arac1 = new KiralikArac("23BCB2331", 500);

            Console.WriteLine("Araç Plaka: " + arac1.Plaka);
            Console.WriteLine("Günlük Ücret: " + arac1.GunlukUcret);
            Console.WriteLine("Müsait mi: " + arac1.MusaitMi);

            arac1.AraciKirala();
            Console.WriteLine("Kiralama sonrası müsait mi: " + arac1.MusaitMi);

            arac1.AraciTeslimEt();
            Console.WriteLine("Teslim sonrası müsait mi: " + arac1.MusaitMi);
            Console.ReadLine();
        }
    }
    class KiralikArac
    {
        public string Plaka { get; private set; }
        public decimal GunlukUcret { get; set; }
        public bool MusaitMi { get; private set; }

        public KiralikArac(string plaka, decimal gunlukUcret)
        {
            Plaka = plaka;
            GunlukUcret = gunlukUcret;
            MusaitMi = true;
        }

        public bool AraciKirala()
        {
            if (MusaitMi)
            {
                MusaitMi = false;
                return true;
            }
            return false;
        }

        public void AraciTeslimEt()
        {
            MusaitMi = true;
        }
    }
}

