using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_06_Dongu_Yapisi
{
    class Program
    {
        static void Main(string[] args)
        {

            //int i = 1;
            //int temp = 0, temp1 = 0;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Sayı: ");
            //    int sayi1 = int.Parse(Console.ReadLine());
            //    int sayi2 = sayi1;
            //    if (temp > sayi1 || temp1 < sayi2)
            //    {
            //        i++;
            //        continue;
            //    }
            //    temp = sayi1;
            //    temp1 = sayi1;
            //}
            //Console.WriteLine("En büyük sayı: " + temp + "En küçük sayı: " + temp1);

            Console.WriteLine("---------------------------------------");

        head:
            try
            {
                Console.WriteLine("1.Sayı: ");
                int s1 = int.Parse(Console.ReadLine());
                string cks = s1.ToString();
                if (cks == "exit")
                {
                    Environment.Exit(0);
                }
                Console.WriteLine("2.Sayı: ");
                int s2 = int.Parse(Console.ReadLine());
                if (s1 > s2)
                {
                    while (s1 - 1 > s2)
                    {
                        Console.WriteLine($"{s2 + 1}\t{Math.Pow(s2 + 1, 2)}\t{Math.Pow(s2 + 1, 3)}");
                        ++s2;
                    }
                }
                else
                {
                    while (s1 < s2 - 1)
                    {
                        Console.WriteLine($"{s1 + 1}\t{Math.Pow(s1 + 1, 2)}\t{Math.Pow(s1 + 1, 3)}");
                        ++s1;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            goto head;

            Console.ReadKey();
        }
    }
}
