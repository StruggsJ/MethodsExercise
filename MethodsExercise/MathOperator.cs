using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    internal class MathOperator
    {
        //TODO: Research how to use the params keyword for the below methods.

        public static void AddNumber()
        {
            Console.WriteLine("What is the first number you want to add?");
            string? num1 = Console.ReadLine();
            int convert1 = Convert.ToInt32(num1);

            Console.WriteLine("What is the second number you want to add?");
            string? num2 = Console.ReadLine();
            int convert2 = Convert.ToInt32(num2);

            int addTotal = convert1 + convert2;

            Console.WriteLine($"{Convert.ToString(convert1)} plus {Convert.ToString(convert2)} is {addTotal} .");
        }

        public static void SubtractNumber()
        {
            Console.WriteLine("What is the first number you want to subtract?");
            string? num1 = Console.ReadLine();
            int convert1 = Convert.ToInt32(num1);

            Console.WriteLine("What is the second number you want to subtract?");
            string? num2 = Console.ReadLine();
            int convert2 = Convert.ToInt32(num2);

            int subtractTotal = convert1 - convert2;
            Console.WriteLine($"{Convert.ToString(convert1)} minus {Convert.ToString(convert2)} is {subtractTotal} .");
        }

        public static void MultiplyNumber()
        {
            Console.WriteLine("What is the first number you want to multiply?");
            string? num1 = Console.ReadLine();
            int convert1 = Convert.ToInt32(num1);

            Console.WriteLine("What is the second number you want to multiply?");
            string? num2 = Console.ReadLine();
            int convert2 = Convert.ToInt32(num2);

            int multiplyTotal = convert1 * convert2;
            Console.WriteLine($"{Convert.ToString(convert1)}  divided by {Convert.ToString(convert2)} is {multiplyTotal} .");
        }

        public static void DivideNumber()
        {
            Console.WriteLine("What is the divisor?");
            string? num1 = Console.ReadLine();
            int convert1 = Convert.ToInt32(num1);

            Console.WriteLine("What is the dividend?");
            string? num2 = Console.ReadLine();
            int convert2 =Convert.ToInt32(num2);

            int divideTotal = convert1 / convert2;

            Console.WriteLine($"{Convert.ToString(convert1)}  divided by {Convert.ToString(convert2)} is {divideTotal} .");
        }

        public static void ModuloNumber ()
        {
            Console.WriteLine("What is the divisor of the divided number you want to find the remainer of?");
            string? num1 = Console.ReadLine();
            int convert1 = Convert.ToInt32(num1);

            Console.WriteLine("What is the dividend of the divided number you want to find the remainder of?");
            string? num2 = Console.ReadLine();
            int convert2 = Convert.ToInt32(num2);

            int remainder = convert1 % convert2;

            Console.WriteLine($"When {Convert.ToString(convert1)} is divided by {Convert.ToString(convert2)}, the remainer is {remainder} .");
            
            
        }
    }
}
