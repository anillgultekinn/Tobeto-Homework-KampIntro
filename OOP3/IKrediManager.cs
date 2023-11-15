using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //interface birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    //hesaplama işlemi tüm kredilerde farklı olduğundan dolayı interface kullanırız
    interface IKrediManager
    {   
        void Hesapla();
        void BiseyYap();

    }
}
