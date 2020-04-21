using System;
using System.Linq;
namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string again = "y";

            Console.WriteLine("Please write your name:");

            string name = Console.ReadLine();

            do
            {                
                
                Console.WriteLine($"{name}, please enter an integer between 1 and 100:");

                string number = Console.ReadLine();

                //Checks if input is a number

                bool result = number.All(Char.IsDigit);

                if(result == false)
                {
                    //Redoes the loop to ask for an integer again
                    continue;
                }
                
                
                int input = int.Parse(number);
                
                //Checks if the number is between 1 and 100

                if ((input > 0) && (input < 101))
                {

                    //sets bools to check if the input is divisable by 2 and under 26

                    bool isEven = input % 2 == 0;

                    bool isLess = input < 26;

                    string output = "";

                    if (isEven && isLess)
                    {
                        output = " is Even and less than 25";
                    }
                    else if (isEven)
                    {
                        output = " is Even";
                    }
                    else
                    {
                        output = " is Odd";
                    }

                    Console.WriteLine(input + output);

                    Console.WriteLine($"{name}, would you like to continue? (y/n)");

                    again = Console.ReadLine();

                    //Checks if they answer either y or n. It needs to be && because it's checking if it is neither of them (it's not y and it's not n)

                    while ((again != "y") && (again != "n"))
                    {
                        Console.WriteLine($"{name}, please enter either y or n:");
                        again = Console.ReadLine();
                    }

                }

            } while (again == "y");

            Console.WriteLine($"Goodbye, {name}!");
        }
    }
}
