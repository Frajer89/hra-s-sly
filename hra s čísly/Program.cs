using System;

namespace hra_s_čísly
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool neuhodl = true;
            Console.Write("Napiš číslo, které bude muset PC uhádnout");
            int cislo = int.Parse(Console.ReadLine());
            while (neuhodl)
            {
                int randomCislo = random.Next(1, 50);
                Console.WriteLine(randomCislo);

                if(randomCislo ==cislo)
                {
                    Console.WriteLine("počítači uhodl si číslo");
                    neuhodl = false;


                }
                else
                {
                    Console.WriteLine("počítači neuhodl si číslo");
                }
                Console.ReadKey();
            }
        }
    }
}
