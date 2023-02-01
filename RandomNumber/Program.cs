using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Number generator");

            Random iRandom = new Random();
            int random = iRandom.Next(1, 4);
            Console.WriteLine(random);



            Console.ReadKey(true);


        }
    }
}
