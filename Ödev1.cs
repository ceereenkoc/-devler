using System;

namespace Ödev1
{
    class Ödev1
    {
        static void Main(string[] args)
        {
            sorular soru = new sorular();
            soru.çiftYazdırma();
            soru.tamBölünen();
            soru.kelimeYazdırma();
            soru.harfKelimeSayma();
        }
    }

    class sorular
    {
        // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
        // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
        // Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        public void çiftYazdırma()
        {
            Console.WriteLine("1. Soru:");
            Console.WriteLine("Pozitif bir sayı giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{n} tane sayı giriniz.");
            int[] sayıDizisi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. sayıyı giriniz:", i+1);
                sayıDizisi[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Çift Sayılar:");
            for (int i = 0; i < n; i++)
            {
                if(sayıDizisi[i] % 2 == 0)
                Console.Write(" " + sayıDizisi[i]);
            }
            Console.WriteLine();
        }

        // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
        // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
        // Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        public void tamBölünen()
        {
            Console.WriteLine("2. Soru:");
            Console.WriteLine("Pozitif iki sayı giriniz.");

            Console.Write("Birinci sayıyı giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{n} tane sayı giriniz.");
            int[] sayıDizisi2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. sayıyı giriniz:", i+1);
                sayıDizisi2[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine($"{m} sayısına bölünen sayılar:");
            for( int i = 0; i < n; i++)
            {
                if(sayıDizisi2[i] % m == 0 )
                    Console.Write(" " + sayıDizisi2[i]);
            }

            Console.WriteLine();
        
        }

        // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
        // Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
        // Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        public void kelimeYazdırma()
        {
            Console.WriteLine("3. Soru:");
            Console.WriteLine("Pozitif bir sayı giriniz.");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{n} tane kelime giriniz.");
            string[] kelimeDizisi = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. kelimeyi giriniz:", i+1);
                kelimeDizisi[i] = Console.ReadLine();
            }
            
            Console.WriteLine("Kelime diziniz:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(" " + kelimeDizisi[i]);
            }
            Console.WriteLine();
        }
   
        // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
        // Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        public void harfKelimeSayma()
        {
            Console.WriteLine("4. Soru:");
            Console.WriteLine("Bir cümle yazınız.");
            string cümle = Console.ReadLine();

            string[] kelime = cümle.Split(' ');
            Console.WriteLine("Kelime sayınız: " + kelime.Count());
            Console.WriteLine("Harf sayınız: " + cümle.Count());
        }
    }
}