using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operand1;
            Console.WriteLine("Prime number detedtor in C#\r");
            Console.WriteLine("------------------------Nataliia Podpriatova\n");

            Console.WriteLine("Type a number, and then press Enter");
            Int32.TryParse(Console.ReadLine(), out operand1);

            CheckSign(operand1);

            string isPrimeMsg = IsPrime(operand1) ? "It is prime" : "It is not prime";
            Console.WriteLine(isPrimeMsg);

            CheckIfDivided(operand1);


            Console.Write("Press any key to close the app");
            Console.ReadLine();
        }

        static private void CheckSign(int number)
        {
            string msg = number > 0 ? "Number is possitive" : "Number is negative";
            Console.WriteLine(msg);
        }

        static private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        static private void CheckIfDivided(int number)
        {
            int[] avalibleDividers = new int[5] { 2, 5, 3, 6, 9 };
            string msg = "A number is divisible without a remainder";
            string msgRemainder = "A number is not divisible without a remainder";

            bool hasRemainder = false;
            foreach (int i in avalibleDividers)
            {
                if ((number % i) != 0)
                {
                    hasRemainder = true;
                }
            }

            Console.WriteLine(hasRemainder ? msgRemainder : msg);
        }
    }
}
