using System;

namespace Cat_Task_5
{
    internal class Program
    {
        delegate int MathOperation(int x, int y);
        static void Main(string[] args)
        {
            Console.Write("Enter Num1:");
            int Num1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Num2:");
            int Num2= Convert.ToInt32(Console.ReadLine());

            MathOperation operation;
            operation = Addition;
            Console.WriteLine($"Addition is : {operation(Num1,Num2)}");
            Console.WriteLine("-----------------------------------------");
            operation = Substraction;
            Console.WriteLine($"Substract is : {operation(Num1, Num2)}");
            Console.WriteLine("-----------------------------------------");
            operation = Multiply;
            Console.WriteLine($"Multiply is :{operation(Num1, Num2)}");
            Console.WriteLine("-----------------------------------------");
            operation = Divide;
            try
            {
                Console.WriteLine($"Division is : {operation(Num1, Num2)}");

            }
            catch(DivideByZeroException ex) 
            {
                Console.WriteLine(ex.Message);
            }

        }
        static int Addition(int a, int b)
        {
            return a + b;
        }
        static int Substraction(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static int Divide(int a, int b)
        {
            if (b != 0)
            {
                return a / b;

            }
            else
            {
                throw new DivideByZeroException("Cannot Divide by Zero");
            }
        }

    }
}
