using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaHesap
{
    class Program
    {
        static void Main(string[] args)
        {
            BankaHesabi hesap1 = new BankaHesabi("123456", 1000);

            hesap1.ParaYatir(500);
            hesap1.ParaCek(200);

            Console.WriteLine("Hesap No: " + hesap1.HesapNumarasi);
            Console.WriteLine("Güncel Bakiye: " + hesap1.Bakiye);
            Console.ReadLine();
        }
    }

    class BankaHesabi
    {
        public string HesapNumarasi { get; private set; }
        public decimal Bakiye { get; private set; }

        public BankaHesabi(string hesapNumarasi, decimal baslangicBakiye)
        {
            HesapNumarasi = hesapNumarasi;
            Bakiye = baslangicBakiye;
        }

        public void ParaYatir(decimal miktar)
        {
            if (miktar > 0)
            {
                Bakiye += miktar;
            }
        }

        public bool ParaCek(decimal miktar)
        {
            if (miktar > 0 && Bakiye >= miktar)
            {
                Bakiye -= miktar;
                return true;
            }
            return false;
        }
    }
}
