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
            
            while (true)
            {
                bool inValid = false;
                do
                {
                    try
                    {
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
                                bool inValid1 = false;
                                do
                                {
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
                                                inValid1 = true;
                                                break;
                                            case 2:
                                                may.MakeOrangeJuice();
                                                inValid1 = true;
                                                break;
                                        }

                                    }
                                    catch (System.Exception)
                                    {
                                        Console.WriteLine("Your input is wrong");
                                    }
                                } while (!inValid1);
                                inValid = true;
                                break;
                            case 2: //Watermelon
                                bool inValid2 = false;
                                do
                                {
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
                                                inValid2 = true;
                                                break;
                                            case 2:
                                                may.MakeWatermelonJuice();
                                                inValid2 = true;
                                                break;
                                        }

                                    }
                                    catch (System.Exception)
                                    {
                                        Console.WriteLine("Your input is wrong");
                                    }
                                } while (!inValid2);
                                inValid = true;
                                break;
                            case 3://Mango
                                bool inValid3 = false;
                                do
                                {
                                    try
                                    {
                                        Console.WriteLine("Choice the type of drink");
                                        Console.WriteLine("1.Smoothie");
                                        Console.WriteLine("2.Juice");
                                        choicetype = Convert.ToInt32(Console.ReadLine());
                                        switch (choicetype)
                                        {
                                            case 1:
                                                may.MakeMangoSmoothie();
                                                inValid3 = true;
                                                break;
                                            case 2:
                                                may.MakeMangoJuice();
                                                inValid3 = true;
                                                break;
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        Console.WriteLine("Your input is wrong");
                                    }
                                } while (!inValid3);
                                inValid = true;
                                break;
                        }
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Your input is wrong");
                    }
                } while (!inValid);
                }
           // Console.ReadKey();
        } 
    }
    
}
