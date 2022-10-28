using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0, sum = 0;
            Console.Write("Bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= sayi; i++)
            {
                sum += i;
            }
            Console.WriteLine($"{sayi}'a kadar olan sayıların toplamı: {sum}");
        }
    }
}
