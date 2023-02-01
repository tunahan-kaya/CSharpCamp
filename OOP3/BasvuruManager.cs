using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(ICreditManager creditManager, ILoggerService loggerService) //Method injection
        {
            //Başvuran bilgilerini değerlendirme,
            creditManager.Hesapla();
            loggerService.Log();
            
        }
        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
        {
            foreach (var item in credits)
            {
                item.Hesapla();
            }
        }
    }
}
