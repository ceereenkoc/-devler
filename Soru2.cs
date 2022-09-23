using System;
using System.Collections;

namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayıListesi = new int[20];
            int[] minList = new int[3];
            int[] maxList = new int[3];

            Console.WriteLine("20 tane sayı giriniz. ");
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0}. sayıyı giriniz: ", i + 1);
                sayıListesi[i] = Convert.ToInt32(Console.ReadLine());   
            }

            Console.WriteLine("Minimum Sayılar için yapılan işlemler");
            
            Array.Sort(sayıListesi);
            minList[0] = sayıListesi [0];
            minList[1] = sayıListesi [1];
            minList[2] = sayıListesi [2];

            int minTop = 0;
            Console.WriteLine("En küçük sayılar:");
            foreach (var item in minList)
            {
                Console.Write(" " + item);
                minTop = minTop + item;
            }
            Console.WriteLine($"\nEn küçük üç sayının toplamı: {minTop}.");
            Console.WriteLine($"En küçük üç sayının ortalaması: {minTop/3}.");

            Array.Reverse(sayıListesi);
            maxList[0] = sayıListesi [0];
            maxList[1] = sayıListesi [1];
            maxList[2] = sayıListesi [2];

            int maxTop = 0;
            Console.WriteLine("En büyük sayılar:");
            foreach (var item in maxList)
            {
                Console.Write(" " + item);
                maxTop = maxTop + item;
            }
            Console.WriteLine($"\nEn büyük üç sayının toplamı: {maxTop}.");
            Console.WriteLine($"En büyük üç sayının ortalaması: {maxTop/3}.");

            

            


        }
    }
}