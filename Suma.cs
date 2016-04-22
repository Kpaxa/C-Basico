using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KpaxaSuma
{ 
class suma
    {
        static void Main(string[] args)
        { 
            int x, y, r;
            Console.WriteLine("Ingrese el primer número: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            y = int.Parse(Console.ReadLine());
            r = x + y;
            Console.WriteLine("El resultados es: " + r);
        }
    }   
}
