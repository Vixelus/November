using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberProject_katarina_johansson
{
    class Cat
    {

        public string Cat1;
        public string Cat2;
        public string Cat3;

       public bool food = false;
        public int Love = 0;
        public int Gold = 10;

        
        public void Name() // you can name your cats here, the name will be later displayed when they visit you.
        {
            Console.WriteLine("Please name the cats you want to visit you:");
            Console.ReadKey();
            Console.WriteLine("Cat1: ");
            Cat1 = Console.ReadLine();
            Console.WriteLine("Cat2: ");
            Cat2 = Console.ReadLine();
            Console.WriteLine("Cat3: ");
            Cat3 = Console.ReadLine();

            Console.WriteLine("Now that you have named all the cats in your area, lets make sure they actually come visit you!");
            Console.ReadKey();
        }


        public void Cats()
        {
            

            for (Gold = 10; Gold> 0; Gold--) // as long as you have more than 0 gold you can play the game
            {
                string[] menu = { "Buy", "Pet" };// start menu ,an array with options the player can choose from
                int selected = 0;
                while (true)
                {

                    for (int i = 0; i < menu.Length; i++)
                    {
                        if (i == selected) Console.Write(">");
                        else Console.Write(" ");
                        Console.WriteLine(menu[i]);
                    }


                    ConsoleKeyInfo key = Console.ReadKey(); 
                    if (key.Key == ConsoleKey.UpArrow) selected--;
                    if (key.Key == ConsoleKey.DownArrow) selected++;
                    if (key.Key == ConsoleKey.Enter) break;

                    Console.Clear();
                    if (selected > menu.Length - 1)
                    {
                        selected = menu.Length - 1;
                    }

                    if (selected < 0)
                    {
                        selected = 0;
                    }

                }

                // choices that depend on what you pick
                if (selected == 0 && Gold >1) //Opens shop, if you have 1 gold or more you can open the shop.
                {


                    string[] items = { "Food", "Toys" }; // an array with options the player can choose from
                    int selection = 0;
                    while (true)
                    {

                        for (int i = 0; i < items.Length; i++)
                        {
                            if (i == selection) Console.Write(">");
                            else Console.Write(" ");
                            Console.WriteLine(items[i]);
                        }


                        ConsoleKeyInfo key = Console.ReadKey(); 
                        if (key.Key == ConsoleKey.UpArrow)
                        {
                            selection--;
                        }
                        if (key.Key == ConsoleKey.DownArrow) selection++;
                        if (key.Key == ConsoleKey.Enter) break;

                        Console.Clear();
                        if (selection > items.Length - 1)
                        {
                            selection = items.Length - 1;
                        }

                        if (selection < 0)
                        {
                            selection = 0;
                        }

                    } // choices that depend on what you pick

                    if (selection == 0 ) // Opens the food shop
                    {

                        string[] Food = { "Tuna:1G", "Sashimi:1G", "Dry food:1G" };// an array with options the player can choose from
                        int select = 0;
                        while (true)
                        {

                            for (int i = 0; i < Food.Length; i++)
                            {
                                if (i == select) Console.Write(">");
                                else Console.Write(" ");
                                Console.WriteLine(Food[i]);
                            }


                            ConsoleKeyInfo key = Console.ReadKey(); 
                            if (key.Key == ConsoleKey.UpArrow) select--;
                            if (key.Key == ConsoleKey.DownArrow) select++;
                            if (key.Key == ConsoleKey.Enter) break;

                            Console.Clear();
                            if (select > Food.Length - 1)
                            {
                                select = Food.Length - 1;
                            }

                            if (select < 0)
                            {
                                select = 0;
                            }

                        } // choices that depend on what you pick
                        if (select == 0)
                        {
                            Console.WriteLine("You bought Tuna!");
                            Gold = -1;
                            food = true;
                            Console.ReadLine();
                        }
                        if (select == 1)
                        {
                            Console.WriteLine("You bought Sashimi!");
                            Gold = -1;
                            food = true;
                            Console.ReadLine();

                        }
                        if (select == 2)
                        {
                            Console.WriteLine("You bought Dry food!");
                            Gold = -1;
                            food = true;
                            Console.ReadLine();
                        }
                    }
                    
                    if (selection == 1) //Open toy shop
                {
                    string[] Toys = { "Ball:1G", "Box:2G", "Cat tree:3G" }; // an array with options the player can choose from
                    int chose = 0;
                    while (true)
                    {

                        for (int i = 0; i < Toys.Length; i++)
                        {
                            if (i == chose) Console.Write(">");
                            else Console.Write(" ");
                            Console.WriteLine(Toys[i]);
                        }


                        ConsoleKeyInfo key = Console.ReadKey();
                            if (key.Key == ConsoleKey.UpArrow) chose--;
                        if (key.Key == ConsoleKey.DownArrow) chose++;
                        if (key.Key == ConsoleKey.Enter) break;

                        Console.Clear();
                        if (chose > Toys.Length - 1)
                        {
                            chose = Toys.Length - 1;
                        }

                        if (chose < 0)
                        {
                            chose = 0;
                        }

                    } // choices that depend on what you pick
                    if (chose == 0)
                    {
                        Console.WriteLine("You bought a Ball!");
                        Gold = -1;
                       
                        Console.ReadLine();
                    }
                    if (chose == 1)
                    {
                        Console.WriteLine("You bought a Box!");
                        Gold = -2;
                        
                        Console.ReadLine();

                    }
                    if (chose == 2)
                    {
                        Console.WriteLine("You bought a Cat tree!");
                        Gold = -3;
                        
                        Console.ReadLine();
                    }
                
                

                    }



            }
            if (selected == 1 && food == true)// pet cat, if you have bought food the cat will automatically appear and then you can pet it with this. You can choose this at the very beginging "Pet"
            {
                   Console.WriteLine("It affection toward you rose!");
                Console.ReadLine();
                    Console.WriteLine("As a token of gratitude he left you some gold");
                    Console.ReadKey();
                Gold = +1;
                Love = +10;
                    

            }
            if (selected == 1 && food == false) // if you do not have any food and therefor not any cats, you cant pet them.
            {
                Console.WriteLine("Cats need to visit you first if you want to pet them, try again!");
            }
                

            

            }
            Console.ReadKey();
        }
         
                
         public void random ()
        { 
          if (food == true) // if you have food the cat comes to visit you
          {
                Random generator = new Random();
                int r = generator.Next(1, 4); // generates a random cat that will visit you.
                if (r == 1)
                {
                    Console.WriteLine(Cat1 + " visited you!"); // the names that you gave them will display when they visit you.
                    Console.ReadLine();
                    

                }
                if(r == 2)
                {
                    Console.WriteLine(Cat2 + " visited you!");
                    Console.ReadLine();

                }
                if(r == 3)
                {
                    Console.WriteLine(Cat3 +" visited you!");
                    Console.ReadLine();

                }

                Console.ReadLine();

          }
        }
        


        




    }
}
