using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            //eğer böyle yaparsak tüm başvurular konut kredisi üzerinden hesaplanır


            krediManager.Hesapla();
            //başvuru kredi bağımsız hale geldi

            //loggerService.Log();

            foreach (var loggerService in loggerServices)
            { 
                loggerService.Log();
            }
        }

        //birden fazla kredinin hesabını yapabiliriz
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
