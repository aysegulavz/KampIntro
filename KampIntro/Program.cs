using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriyi çok severim";

            Console.WriteLine(kategoriEtiketi);

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("artış oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("azalış oku");
            }
            else
            {
                Console.WriteLine("değişmedi oku");
            }
            bool SistemeGirisYapmisMi=false;

            if (SistemeGirisYapmisMi==true)
            {
                Console.WriteLine("kullanici ayarlari butonu");
            }
            else
            {
                Console.WriteLine("giris yap butonu");
            }
        }
    }
}
