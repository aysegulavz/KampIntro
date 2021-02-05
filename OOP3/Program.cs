using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtıyacKrediManager ıhtıyacKrediManager = new IhtıyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseloggerservice = new DatabseLoggerService();
            ILoggerService fileloggerservice = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,databaseloggerservice);

            List<IKrediManager> krediler = new List<IKrediManager>() {ıhtıyacKrediManager,tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
            
        }
    }
}
