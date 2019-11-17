using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        { //klavyeen girilen sayınn çarpanlarını bulan prog
            
           
            Console.Write("Bir Sayı Giriniz=");
            int s = int.Parse(Console.ReadLine());
          
            for (int i = 1; i <= s; i++)
            {
                if (s % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
           
            Console.ReadKey();

        }
    }
}
