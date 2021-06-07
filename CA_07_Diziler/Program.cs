using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_07_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[6] { 45, 928, 78, 4, 1007, 83 };

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write($"{dizi[i]}\n");
            }

            Console.WriteLine("---------------");

            for (int j = dizi.Length - 1; j >= 0; j--)
            {
                Console.Write($"{dizi[j]}\n");
            }

            Console.WriteLine("--------------");

            for (int k = 0; k < dizi.Length; k++)
            {
                while (k < dizi.Length - 1)
                {
                    Console.Write($"{dizi[k]} - ");
                    k++;
                }
                Console.WriteLine(dizi[k]);

            }

            Console.WriteLine("-------------------------");

            for (int l = 0; l < dizi.Length; l++)
            {
                Console.WriteLine($"{dizi[l]}\t{dizi[++l]}");
            }

            Console.WriteLine();

            for (int m = 0; m < dizi.Length - 2; m += 3)
            {
                Console.Write($"{dizi[m + 2]}\t{dizi[m + 1]}\t{dizi[m]}\n");
            }

            Console.WriteLine("-------------------------------");

            int[] dizi2 = new int[dizi.Length];
            int z = dizi.Length;
            for (int n = 0; n < dizi2.Length; n++)
            {
                dizi2[n] = dizi[z - 1];
                z--;
            }
            foreach (var item in dizi2)
            {
                Console.WriteLine(item);
            }

            int temp = 0;
            int s = 0;
            for (int t = 1; t < dizi.Length / 2; t++)
            {
                temp = dizi[dizi.Length - t];
                dizi[dizi.Length - t] = dizi[s];
                dizi[s] = temp;
                s++;

            }

            foreach (var item1 in dizi)
            {
                Console.WriteLine(item1);
            }

            Console.ReadKey();
        }
    }
}
