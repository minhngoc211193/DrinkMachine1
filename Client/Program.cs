using DrinkMachineLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x > 0)
            {
                try {
                    int choicetype;
                    DrinkMachine may = new DrinkMachine();
                    Console.WriteLine("Please choice type of Fruit");
                    Console.WriteLine("1. Orange");
                    Console.WriteLine("2. Watermelon");
                    Console.WriteLine("3. Mango");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1://Orange
                            try
                            {
                                Console.WriteLine("Choice the type of drink");
                                Console.WriteLine("1.Smoothie");
                                Console.WriteLine("2.Juice");
                                choicetype = Convert.ToInt32(Console.ReadLine());

                                switch (choicetype)
                                {
                                    case 1:
                                        may.MakeOrangeSmoothie();
                                        break;
                                    case 2:
                                        may.MakeOrangeJuice();
                                        break;
                                }

                            }
                            catch (System.Exception)
                            {
                                Console.WriteLine("Your input is wrong");
                            }
                            break;
                        case 2: //Watermelon
                            try
                            {
                                Console.WriteLine("Choice the type of drink");
                                Console.WriteLine("1.Smoothie");
                                Console.WriteLine("2.Juice");
                                choicetype = Convert.ToInt32(Console.ReadLine());
                                switch (choicetype)
                                {
                                    case 1:
                                        may.MakeWatermelonSmoothie();
                                        break;
                                    case 2:
                                        may.MakeWatermelonJuice();
                                        break;
                                }
                            } catch (System.Exception)
                            {
                                Console.WriteLine("Your input is wrong");
                            }
                            break;
                        case 3://Mango
                            try {
                                Console.WriteLine("Choice the type of drink");
                                Console.WriteLine("1.Smoothie");
                                Console.WriteLine("2.Juice");
                                choicetype = Convert.ToInt32(Console.ReadLine());
                                switch (choicetype)
                                {
                                    case 1:
                                        may.MakeMangoSmoothie();
                                        break;
                                    case 2:
                                        may.MakeMangoJuice();
                                        break;
                                }
                            }
                            catch (System.Exception)
                            {
                                Console.WriteLine("Your input is wrong");
                            }
                            break;
                    }
                }
                catch(System.Exception) {
                    Console.WriteLine("Your input is wrong");
                }
                }
            Console.ReadKey();
        } 
    }
    
}
