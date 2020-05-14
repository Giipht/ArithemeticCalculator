using System;

namespace ArithmeticCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers : ");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nAddition : " + (a + b));
            Console.WriteLine("Subtraction : " + (a - b));
            Console.WriteLine("Multiplication : " + (a * b));
            Console.WriteLine("Division : " + (a / b));
           

            Console.Read();
        }
    }
}
