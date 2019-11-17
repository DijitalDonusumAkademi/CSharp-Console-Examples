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
        {  // mükemmel sayı= kendisi hariç tam çarpanları toplamı kendisine eşit olan sayılara denir
           
            Console.Write("Sayı Giriniz=");
            int sayı = int.Parse(Console.ReadLine());
            int toplam = 0;
            for (int i = 1; i < sayı; i++)
            {
                if (sayı%i==0)
                {
                    toplam += i;
                }
            }
            if (toplam == sayı)
            {
                Console.WriteLine("Mükemmel sayıdır");
            }
            else
                Console.Write("Mükemmel değil");
            Console.ReadKey();
        }
    }
}
