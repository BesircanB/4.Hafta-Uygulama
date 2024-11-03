using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdresDefteri
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi1 = new Kisi("Ali", "a", "5551234567");
            Kisi kisi2 = new Kisi("Ayşe", "b", "5559876543");

            Console.WriteLine(kisi1.KisiBilgisi());
            Console.WriteLine(kisi2.KisiBilgisi());

            // Bilgi güncelleme
            kisi1.TelefonNumarasi = "5553334444";
            Console.WriteLine("\nGüncellenmiş bilgi:");
            Console.WriteLine(kisi1.KisiBilgisi());
            Console.ReadLine();
        }
    }

    class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelefonNumarasi { get; set; }

        public Kisi(string ad, string soyad, string telefonNumarasi)
        {
            Ad = ad;
            Soyad = soyad;
            TelefonNumarasi = telefonNumarasi;
        }

        public string KisiBilgisi()
        {
            return $"{Ad} {Soyad} - Tel: {TelefonNumarasi}";
        }
    }
}
