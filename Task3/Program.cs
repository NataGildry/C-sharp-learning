using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int conwertSelection;
            Console.WriteLine("Console currency converter in C#\r");
            Console.WriteLine("------------------------Nataliia Podpriatova\n");
            Console.WriteLine("Enter your Choice :\n 1- USD to UAH \n 2 - EUR to UAH");
            Int32.TryParse(Console.ReadLine(), out conwertSelection);
            Double dollar, euro, val;

            switch (conwertSelection)
            {
                case 1:
                    Console.WriteLine("Enter the Dollar amount :");
                    Double.TryParse(Console.ReadLine(), out dollar);

                    Console.WriteLine("Enter the Dollar value :");
                    double.TryParse(Console.ReadLine(), out val);

                    Double dollarToUah = dollar * val;

                    Console.WriteLine("{0} USD equals {1} UAH", dollar, dollarToUah);
                    break;
                case 2:
                    Console.WriteLine("Enter the Euro amount :");
                    Double.TryParse(Console.ReadLine(), out euro);

                    Console.WriteLine("Enter the Euro Value :");
                    double.TryParse(Console.ReadLine(), out val);

                    Double eurToUah = euro * val;
                    Console.WriteLine("{0} Euro equals {1} UAH", euro, eurToUah);
                    break;
            }

            Console.Write("Press any key to close the app");
            Console.ReadLine();
        }
    }
}
