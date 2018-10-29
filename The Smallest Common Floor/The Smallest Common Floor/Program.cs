using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Smallest_Common_Floor
{
    class Program
    {
        static void Main(string[] args)
        {

            // Kullanıcının vermiş olduğu 2 sayının en küçük ortak katını(ekok) bulabilecek algoritmayı tasarlayınız.

            int sayı_1 = 0, sayı_2 = 0;
            Console.Write("1. sayıyı giriniz : ");
            sayı_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz : ");
            sayı_2 = Convert.ToInt32(Console.ReadLine());

            if (sayı_1 % sayı_2 == 0)
            {
                Console.WriteLine("Girmiş olduğunuz sayıların en küçük ortak katı = " + sayı_1);

            }
            else if (sayı_2 % sayı_1 == 0)
            {
                Console.WriteLine("Girmiş olduğunuz sayıların en küçük ortak katı = " + sayı_2);
            }
            else
            {
                Console.WriteLine("Girmiş olduğunuz sayıların en küçük ortak katı = " + (sayı_1 * sayı_2));
            }



        }
    }
}
