using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1 = 10;
            double sayi2 = 15;
            double toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);

            double fark = sayi1 - sayi2;
            Console.WriteLine(fark);

            double carpim = sayi1 * sayi2;
            Console.WriteLine(carpim);

            //bir tamsayının başka bir tamsayıya bölümü tamsayı verir
            double bolum = sayi1 / sayi2;
            Console.WriteLine(bolum);
        }
    }
}
