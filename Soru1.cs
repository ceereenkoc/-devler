using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalSayılar = new ArrayList();
            ArrayList asalOlmayanSayılar = new ArrayList();
            Regex kontrol = new Regex("^[0-9]*$");
            int sayaç = 0;

            Console.WriteLine("20 tane sayı giriniz. ");
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0}. sayıyı giriniz: ", i + 1);
                string sayı = Console.ReadLine();
                if (!kontrol.IsMatch(sayı) || (Convert.ToInt32(sayı) < 0))
                {
                    Console.WriteLine("Hatalı tuşlama! Lütfen sıfırdan büyük harf içermeyen bir sayı giriniz.");
                }
                else
                {
                    int s = Convert.ToInt32(sayı);
                    for (int j = 2; j <= s - 1; j++)
                    {
                        if (s % j == 0)
                        {
                            sayaç++;
                        }
                    }
                    if (sayaç == 0)
                        asalSayılar.Add(s);
                    else
                        asalOlmayanSayılar.Add(s);
                    sayaç = 0;
                }
            }
            Console.WriteLine("***AsalSayılar***");
            foreach (var item in asalSayılar)
                Console.Write(" " + item);

            Console.WriteLine();

            Console.WriteLine("***AsalOlmayanSayılar***");
            foreach (var item in asalOlmayanSayılar)
                Console.Write(" " + item);

            Console.WriteLine("\n ----BüyüktenKüçüğeSıralama/ElemanSayısı/Ortalama---");

            asalSayılar.Sort();
            asalSayılar.Reverse();

            int AT = 0;
            foreach (int item in asalSayılar)
            {
                Console.Write(" " + item);
                AT = AT + item;
            }
            
            Console.WriteLine($"\n {asalSayılar.Count} tane asal sayı girdiniz.");
            Console.WriteLine($"Asal Sayıların Ortalaması: {AT/asalSayılar.Count}");
            
            

            asalOlmayanSayılar.Sort();
            asalOlmayanSayılar.Reverse();

            int AOT = 0;
            foreach (int item in asalOlmayanSayılar)
            {
                Console.Write(" " + item);
                AOT = AOT + item;
            }
            
            Console.WriteLine($"\n {asalOlmayanSayılar.Count} tane asal olmayan sayı girdiniz.");
            Console.WriteLine($"Asal Olmayan Sayıların Ortalaması: {AOT/asalOlmayanSayılar.Count}");
            
        }
    }
}