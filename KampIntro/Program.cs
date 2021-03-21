 using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Decreas Button");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Increment Button");
            }
            else
            {
                Console.WriteLine("Notr Button");
            }

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Welcome To System");
            }
            else
            {
                Console.WriteLine("Register Button");
            }




        }
    }
}
