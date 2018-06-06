using ConsoleApplication2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int max2 = rand.Next(4, 8);
            for (int i = 0; i < max2; i++)
            {
                Generowanie3 gen = new Generowanie3();
                var kolejnelitery = gen.GetRandomChar(gen.samo.Select(a => a.Key).ToArray(), gen.spol.Select(a => a.Key).ToArray());
                Console.Write(gen.GetRandomChar(gen.DozwoloneSamo(kolejnelitery), gen.DozwoloneSpol(kolejnelitery)));
            }

            Console.ReadKey();

        }
    }
}
