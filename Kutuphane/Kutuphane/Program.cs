using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    class Program
    {
        static void Main(string[] args)
        {
            Kutuphane kutuphane = new Kutuphane();

            Kitap kitap1 = new Kitap("Suç ve Ceza", "Dostoyevski", 687);
            Kitap kitap2 = new Kitap("1984", "George Orwell", 352);

            kutuphane.KitapEkle(kitap1);
            kutuphane.KitapEkle(kitap2);

            kutuphane.KitaplariListele();
            Console.ReadLine();
        }
    }
    public class Kitap
    {
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public int SayfaSayisi { get; set; }

        public Kitap(string ad, string yazar, int sayfaSayisi)
        {
            this.Ad = ad;
            this.Yazar = yazar;
            this.SayfaSayisi = sayfaSayisi;
        }
    }
    public class Kutuphane
    {
        private List<Kitap> Kitaplar;

        public Kutuphane()
        {
            this.Kitaplar = new List<Kitap>();
        }

        public void KitapEkle(Kitap yeniKitap)
        {
            this.Kitaplar.Add(yeniKitap);
        }

        public void KitaplariListele()
        {
            foreach (var kitap in this.Kitaplar)
            {
                Console.WriteLine($"Kitap Adı: {kitap.Ad}, Yazarı: {kitap.Yazar}, Sayfa Sayısı: {kitap.SayfaSayisi}");
            }
        }
    }


}
