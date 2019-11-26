using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProject_katarina_johansson
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Cat c = new Cat();
           


            Console.WriteLine("Welcome to the cat collector! :3");
            Console.WriteLine("You start of the game with 10G");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You can spend it on buying things for your yard so that cats will visit you.");
            Console.WriteLine("(Without food cats won't visit you)");
            Console.ReadKey();
            Console.Clear();

            c.Name();
           
              c.Cats();
           

            c.random();

            c.Cats();
           
            Console.ReadKey();
            
                   

            

        }
    }
}
