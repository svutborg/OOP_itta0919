using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3e._2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int choice = printMenu();
                switch (choice)
                {
                    case 1:// reverse digits
                        Console.WriteLine("Enter an integer number to reverse:");
                        int intNum;
                        if (int.TryParse(Console.ReadLine(), out intNum))
                        {
                            if (intNum >= 1 && intNum <= 50000000) //checking for 3e.3
                            {
                                Console.WriteLine($"The reverse of {intNum} is {ReverseDigits(intNum)}");
                            }
                        }
                        break;
                    case 2:// calculate average
                        Console.WriteLine("Enter a sequence of integer numbers (separated by comma):");
                        string ans = Console.ReadLine();
                        int[] numbers = ans.Split(',').Select(int.Parse).ToArray();
                        if (numbers.Length > 0) //checking for 3e.3
                        {
                            Console.WriteLine($"The average of {ans} is {CalculateAverage(numbers)}");
                        }
                        break;
                    case 3:// solve equation
                        Console.WriteLine("Enter numbers a and b from an equation of the form ax+b=0:");
                        Console.Write("a: ");
                        string strA = Console.ReadLine();
                        Console.Write("b: ");
                        string strB = Console.ReadLine();
                        double a, b;
                        if (double.TryParse(strA, out a) && double.TryParse(strB, out b))
                        {
                            if (a != 0) //checking for 3e.3
                            {
                                Console.WriteLine($"The solution to the euqation {a}x+{b}=0 is: x={SolveLinearEquation(a, b)}");
                            }
                        }
                        break;
                    default: // non valid input 
                        Console.WriteLine("Non-valid input");
                        break;
                }
            }
        }

        static int printMenu()
        {
            int result;
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1: Reverse digits");
            Console.WriteLine("2: Calculate average");
            Console.WriteLine("3: Sovle equation");
            int.TryParse(Console.ReadLine(), out result);
            return result;
        }
        static int ReverseDigits(int number)
        {
            int answer = 0;

            while(number > 10)
            {
                answer = answer * 10 + number % 10;
                number /= 10;
            }
            answer = answer * 10 + number % 10;

            return answer;
        }

        static double CalculateAverage(params int[] numbers)
        {
            double sum = 0; 
            foreach (double num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }

        // Solves the linear equation a * x + b = 0. for x, given a and b
        static double SolveLinearEquation(double a, double b)
        {
            return -b / a;
        }

    }
}
