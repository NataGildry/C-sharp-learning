using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double operand1;
            double operand2;
            double operand3;

            Console.WriteLine("Arithmetic mean in C#\r");
            Console.WriteLine("------------------------Nataliia Podpriatova\n");

            Console.WriteLine("Type the number, and then press Enter");
            Double.TryParse(Console.ReadLine(), out operand1);

            Console.WriteLine("Type second number, and then press Enter");
            Double.TryParse(Console.ReadLine(), out operand2);


            Console.WriteLine("Type third number, and then press Enter");
            Double.TryParse(Console.ReadLine(), out operand3);

            Calculate(operand1, operand2, operand3);

            Console.Write("Press any key to close the app");
            Console.ReadLine();
        }

        static private void Calculate(double operand1, double operand2, double operand3)
        {
            double[] numbers = new double[3] { operand1, operand2, operand3 };

            int average = Convert.ToInt32(numbers.Average());

            Console.WriteLine("Arithmetic mean is " + average);
        }
    }
}
