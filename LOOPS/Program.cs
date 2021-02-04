using System;

namespace LOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kampı";
            string kurs2 = "programlamaya baslangıc icin temel kurs";
            string kurs3 = "JAVA";

            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı",
               "programlamaya baslangıc icin temel kurs", "JAVA"};

            for(int i=0;i<kurslar.Length;i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
