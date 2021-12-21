using System;

namespace calculator._21._12.unit
{
 
        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("my calculator");
                double a, b;
                char op;

                Console.WriteLine("Enter value 1");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter operator( its can be -, +, *, /, ^ ");
                op = char.Parse(Console.ReadLine());
                Console.WriteLine("Enter value 2");
                b = double.Parse(Console.ReadLine());

                switch (op)
                {
                    case '-':
                        Console.WriteLine(Metod_calculat.Minus(a, b));
                        break;
                    case '+':
                        Console.WriteLine(Metod_calculat.Plus(a, b));
                        break;
                    case '*':
                        Console.WriteLine(Metod_calculat.Multiply(a, b));
                        break;
                    case '/':
                        Console.WriteLine(Metod_calculat.Divide(a, b));
                        break;
                    case '^':
                        Console.WriteLine(Metod_calculat.Square(a));
                        break;
                    default:
                        throw new Exception("Enter correct data");

                }

                Console.ReadLine();
                Console.Clear();

            }
        }
    
}
