using System;
using System.Collections.Generic;

namespace Patrones_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora String");

            while (true)
            {
                string input = Console.ReadLine();
                int result = new Context().InsertExpression(input);
                Console.WriteLine($"{input} = {result}");
            }
        }
    }

}
