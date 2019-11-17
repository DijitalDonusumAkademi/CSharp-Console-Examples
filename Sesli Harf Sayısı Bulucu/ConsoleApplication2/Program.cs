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
        {
            string[] seslıh = new string[8]; int sayac = 0;
            seslıh[0] = "a";
            seslıh[1] = "e";
            seslıh[2] = "ı";
            seslıh[3] = "i";
            seslıh[4] = "o";
            seslıh[5] = "ö";
            seslıh[6] = "u";
            seslıh[7] = "ü";
            Console.Write("Cümle Giriniz=");
            string cumle = Console.ReadLine();
            for (int i = 0; i < cumle.Length; i++)
            {
                for (int j = 0; j <8; j++)
                {
                    if (seslıh[j]==cumle[i].ToString())
                    {
                        sayac++;
                    }
                }
            }
            Console.WriteLine("Girdiğiniz cümledeki sesli harf sayısı="+sayac);
            Console.ReadKey();
        }
    }
}
