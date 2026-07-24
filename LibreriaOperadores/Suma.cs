using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaOperadores
{
    public class Suma
    {
        public int resultado;
        public Suma(int num1, int num2)
        {
            resultado = num1 + num2;
            Console.WriteLine(resultado + " es el resultado de la suma");
        }
    }
}
