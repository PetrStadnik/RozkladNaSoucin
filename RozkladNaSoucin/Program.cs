using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozkladNaSoucin
{
    class Program
    {
        public List<int> list;

        static void Main(string[] args)
        {
            
            
            int x = 1;
            Program program = new Program();
            Console.WriteLine("Vítejte v aplikaci pro prvočíselný rozklad čísel");

            while (x > 0)
            {


                Console.WriteLine("\nZadejte číslo! (0 pro ukončení)");

                while (!int.TryParse(Console.ReadLine(), out x))
                    Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");
                Console.WriteLine("Rozkald:");
                foreach ( int p in program.Vypocitej(x))
                {
                    Console.Write(" {0}", p);
                }
                Console.Write("\n");

            }

        }

        public List<int> Vypocitej(int x)
        {
            list = new List<int>();
            
            for (int i = 1; i <= x; i++)
            {
                
                if (x % i == 0)
                {
                    list.Add(i);
                    x = x / i;
                    i = 1;
                }

                   
            }
            


            return list;
        }
    }
}
