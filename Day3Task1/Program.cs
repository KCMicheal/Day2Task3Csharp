using System;

namespace Day3Task1
{
    public class Calculator
    {
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            int add2 = calculator.Add(45, 43, 67);
            int add1 = calculator.Add(23, 34);
            Console.WriteLine(add2);
            Console.WriteLine(add1);
        }
    }
}
