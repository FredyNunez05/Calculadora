using LibreriaOperadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indique el 1er numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Indique el 2do numero: ");
            int numero2 = int.Parse(Console.ReadLine());
            Multiplicacion division = new Multiplicacion(numero1, numero2);
            Console.WriteLine($"Resultado de la división: {division.resultado}");
            
        }
    }
}
