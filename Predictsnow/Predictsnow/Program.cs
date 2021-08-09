using System;

namespace Predictsnow
{
    class Program
    {
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
