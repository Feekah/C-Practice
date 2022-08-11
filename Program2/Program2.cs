using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goal
{
    class Prog
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter aany of these operators: +, -, *, and / ");
            string numoperator = Console.ReadLine();


            Console.WriteLine(operation(num1, num2, numoperator));




        }



        static double operation(double num1, double num2, string numoperator)
        {
            double result = 0;

            if (numoperator == "+")
            {
                result = num1 + num2;
            }

            else if (numoperator == "-")
            {
                result = num1 - num2;
            }

            else if (numoperator == "*")
            {
                result = num1 * num2;
            }

            else if (numoperator == "/")
            {
                result = num1 / num2;
            }

            else
            {
                Console.WriteLine("Invalid Operator");
            }
            return result;
        }

    }
}


string secretword = "love";
string guess = "";
int guesscount = 0;
int guesslimit = 4;
bool outofguesses = false;

while (guess != secretword && !outofguesses)
{
    if (guesscount < guesslimit)
    {
        Console.WriteLine("Please enter a secret word");
        guess = Console.ReadLine();
        guesscount++;

    }

    else
    {
        outofguesses = true;
    }

}
if (outofguesses)
{
    Console.WriteLine("You lose!");
}
else
{
    Console.WriteLine("You win!");
}