using System;
using System.Collections;

namespace Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sesliHarf = new ArrayList();
            Console.WriteLine("Lütfen bir cümle yazınız:");
            char[] cümle = (Console.ReadLine()).ToCharArray();
            foreach (var h in cümle)
            {
                if (h == 'a' || h == 'e'|| h == 'ı' ||h == 'i' ||h == 'o' ||h == 'ö' ||h == 'u' || h == 'ü')
                {
                    sesliHarf.Add(h);
                }
            }

            sesliHarf.Sort();
            foreach (var item in sesliHarf)
                Console.Write(" " + item);             
        }
    }
}
