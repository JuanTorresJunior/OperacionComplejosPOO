using System;
using System.Collections.Generic;

namespace OperacionComplejosPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Complejo i1 = new Complejo(10, 6);
            Complejo i2 = new Complejo(8, 1);

            Console.WriteLine($"Suma: { i1 + i2 }");
            Console.WriteLine($"Resta: { i1 + i2 }");
            Console.WriteLine($"Multiplicación: { i1 + i2 }");
            Console.WriteLine($"Multiplicación con un Double: { i1 * 2.5 }");
            Console.WriteLine($"División: { i1 / i2 }");


        }
    }
}
