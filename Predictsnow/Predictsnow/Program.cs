using System;

namespace Predictsnow
{
    class Program
    {
        static void Predic()
        {
            Console.WriteLine("temp check thing");

            Console.WriteLine("What is temp");
            int degrees = Convert.ToInt32(Console.ReadLine());


            // int degrees = 
            if (degrees < -20)
            {
                Console.WriteLine("to cold");
            }
            else
            {
                if (degrees < -9)
                {
                    Console.WriteLine("perfect");
                }
                else
                {
                    if (degrees > 0)
                    {
                        Console.WriteLine("to warm");
                    }
                    else
                    {
                        Console.WriteLine("Unknown weather patern");
                    }

                }
            }
            Console.ReadLine();
        }
        static void Main()
        {
            string temp;
            int start = 1;
            do
            {
                Console.Clear();
                Console.WriteLine("Predict Snow Menu\n\n1. Enter Data.\n2. Exit.");
                temp = Console.ReadLine();
                switch (temp)
                {
                    case "1":
                        break;
                    case "2":
                        start = 0;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid input\n\nPress ENTER to continue");
                        break;
                }
            } while (start == 1);
        }        
    }
}
