using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KpaxaSuma
{ 
class suma
    {
        public static double Sumar(double numero1, double numero2){
            double resultado = numero1 + numero2;
            return resultado;
        }
        
        static void Main(string[] args)
        { 
            double numero1, numero2;
            Console.Write("Ingrese el primer número: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultados es: " + Sumar(numero1,numero2).toString());
            Console.ReadKey();
        }
    }   
}
