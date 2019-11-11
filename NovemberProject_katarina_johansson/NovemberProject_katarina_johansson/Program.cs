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
            Cat c1 = new Cat();
            Console.WriteLine("Welcome to the cat collector! :3");
            Console.WriteLine("You have 10G");
            Console.ReadKey();
            Console.WriteLine("Without food cats won't visit you");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Would you like to buy food?");
            Console.WriteLine("A) Yes B) No");
           string answer =  Console.ReadLine();
            string A = "A";
            if ( answer = A)
            {
               Console.WriteLine("How much food do you want to buy?");

            }
                   

            

        }
    }
}
