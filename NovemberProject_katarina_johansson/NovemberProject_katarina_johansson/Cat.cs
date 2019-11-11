using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProject_katarina_johansson
{
    class Cat
    {

        public string name;
           private  string cuteness;
           private  string Power;
        public int howmany;

        static string[] option = { " Start", " Quit" };
        static int index = 0;
        static string[] fight = { " Buy", "Pet", " Quit" + "" };



        public static int Selection()
        {
            while (true)
            {
                for (int i = 0; i < option.Length; i++)
                {
                    string text = "";
                    if (index == i)
                        text += ">";
                    text += option[i];
                    Console.WriteLine(text);
                }
                ConsoleKeyInfo input = Console.ReadKey(); //get a key input from the player
                if (input.Key == ConsoleKey.UpArrow) //go up
                    index--;
                if (input.Key == ConsoleKey.DownArrow) //go down
                    index++;
                if (input.Key == ConsoleKey.Enter)
                {

                    return index;
                }

                Console.Clear();
                if (index <= 0)
                {
                    index = 0;
                    Console.Clear();
                }

                if (index >= 1)

                {
                    index = 1;


                }
            }
        }
        public void Names()
        {
           
            string length = Console.ReadLine();
           List<string> Catnames = new List<string>();

           int length = Catnames.Count;
           
        }
      


    }
}
