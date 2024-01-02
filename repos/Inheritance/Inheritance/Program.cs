using System;


namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number for Addition:");
            int number1=int.Parse(Console.ReadLine()); 
            int number2=int.Parse(Console.ReadLine());

            AdvanceCalculator calculator = new AdvanceCalculator();
            Console.WriteLine(calculator.Add(number1 ,number2));


            Console.WriteLine("Enter two number for Multiplication:");
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            
            Console.WriteLine(calculator.Multiply(number3, number4));
        }
    }
}
