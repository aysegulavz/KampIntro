using System;

namespace CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //kurs diye bi değişkeni aşağıda kendimiz oluşturuyoruz.

            Kurs kurs1 =new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "engin demirog";
            kurs1.KursunİzlenmeOrani = 100;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "python";
            kurs2.Egitmen = "burhan ozkan";
            kurs2.KursunİzlenmeOrani =90;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "java";
            kurs3.Egitmen = "aysegul ayvaz";
            kurs3.KursunİzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }

        }
    }
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int KursunİzlenmeOrani { get; set; }
}

