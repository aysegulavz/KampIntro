using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            double urunFiyati = 15;
            string urunAcıklama = "Amasya Elması";


            string[] meyveler = new string[] { };

            Product urun1 = new Product();
            urun1.Adi = "elma";
            urun1.Aciklama = "amasya elması";
            urun1.Fiyati = 15;

            Product urun2 = new Product();
            urun2.Adi = "karpuz";
            urun2.Aciklama = "diyarbakır karpuzu";
            urun2.Fiyati = 30;

            Product urun3 = new Product();
            urun3.Adi = "muz";
            urun3.Aciklama = "anamur muzu";
            urun3.Fiyati = 60;


            Product[] urunler = new Product[] { urun1, urun2, urun3 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("---------------");
                    
            }

            Console.WriteLine("-------metotlar----------");

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);








        }
    }
}
