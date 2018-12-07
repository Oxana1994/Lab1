using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Interface
    {
        public static void StartInterface()
        {
            Console.WriteLine("Please Enter two numbers");
            Console.WriteLine("Enter first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Choose an action\n1 Plus\n2 Minus\n3 Multiply\n4 Split");
            int actionNumber = int.Parse(Console.ReadLine());

            switch (actionNumber)
            {
                case 1:
                    Console.WriteLine("Result is " + Actions.Increaser(x, y));
                    break;
                case 2:
                    Console.WriteLine("Result is " + Actions.Increaser(x, y));
                    break;
                case 3:
                    Console.WriteLine("Result is " + Actions.Increaser(x, y));
                    break;
                case 4:
                    Console.WriteLine("Result is " + Actions.Increaser(x, y));
                    break;
                default:
                    Console.WriteLine("Result is " + Actions.Increaser(x, y));
                    break;
            }
            Console.WriteLine("Do you want to make another operation? Y/N");
            string yesNo = Console.ReadLine();
            if (yesNo.ToLower().Equals("y"))

                StartInterface();
            else return;
        }
    }
}
