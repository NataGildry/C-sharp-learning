using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operand1;
            int operand2;
            string sign;

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------Nataliia Podpriatova\n");

            Console.WriteLine("Type a number, and then press Enter");
            Int32.TryParse(Console.ReadLine(), out operand1);

            Console.WriteLine("Type another number, and then press Enter");
            Int32.TryParse(Console.ReadLine(), out operand2);

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\t+ - Add");
            Console.WriteLine("\t- - Subtract");
            Console.WriteLine("\t* - Multiply");
            Console.WriteLine("\t/ - Divide");
            Console.Write("Your option? ");

            sign = Console.ReadLine();
            Console.WriteLine("Selected option: " + sign);

            switch (sign)
            {
                case "+":
                    Add(operand1, operand2);
                    break;
                case "-":
                    Sub(operand1, operand2);
                    break;
                case "*":
                    Mul(operand1, operand2);
                    break;
                case "/":
                    Div(operand1, operand2);
                    break;
            }

            Console.Write("Press any key to close the app");
            Console.ReadKey();
        }

        static private void Add(int operand1, int operand2)
        {
            Console.WriteLine($"Your result: {operand1} + {operand2} = " + (operand1 + operand2));
        }

        static private void Sub(int operand1, int operand2)
        {
            Console.WriteLine($"Your result: {operand1} - {operand2} = " + (operand1 - operand2));
        }

        static private void Mul(int operand1, int operand2)
        {
            Console.WriteLine($"Your result: {operand1} * {operand2} = " + (operand1 * operand2));
        }

        static private void Div(int operand1, int operand2)
        {
            if (operand2 == 0)
            {
                Console.WriteLine($"Not possible to divide on O");
                return;
            }

            Console.WriteLine($"Your result: {operand1} / {operand2} = " + (operand1 / operand2));
        }
    }
}
