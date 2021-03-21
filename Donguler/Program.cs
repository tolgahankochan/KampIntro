using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string kurs1 = "Yazılım Kursu";
            string kurs2 = "Programlamaya Başlarken";
            string kurs3 = "Java Kursu";
            */

            string[] kurslar = new string[] { "Yazılım Kursu", "Programlamaya Başlarken", "Java Kursu","Pyhton","C++ kursu" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("----Sayfa Sonu----");
        }
    }
}
