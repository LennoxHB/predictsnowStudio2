using System;

namespace Predictsnow
{
    class Program
    {
                public static int[] Stats()
        {
            int[] Snow_Stats = new int[4];
            bool Correct = false;
            int temp;
            do
            {
                Console.WriteLine("Please Enter The Air Tempeture");
                Snow_Stats[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter The Ground Tempeture");
                Snow_Stats[1] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter The Wind Direction 1 for North 2 For South 3 For East 4 For West");
                Snow_Stats[2] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter The Humidity");
                Snow_Stats[3] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Would You Like To Reenter Your Figures Or Are They Correct? 1 To Go Back 2 For Correct");
                temp = Convert.ToInt32(Console.ReadLine());
                if (temp == 1)
                {
                    Correct = false;
                }
                else
                {
                    Correct = true;
                }
            } while (Correct == true);
            return Snow_Stats[];

        }
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
