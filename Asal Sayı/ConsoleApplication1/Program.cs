using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Giriniz=");
            int sayac=0;
            int sayı = int.Parse(Console.ReadLine());
            for (int i = 2; i <sayı; i++)
            {
                if (sayı % i == 0)
                {
                    sayac++;
                    Console.WriteLine("SAYI ASAL DEĞİLDİR");
                    break;
                }
            }
            if (sayac==0)
            {
                Console.Write("SAYI ASALDIR");
            }
             Console.ReadKey();
        }
    }
}
