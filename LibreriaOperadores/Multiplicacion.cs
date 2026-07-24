using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaOperadores
{
    public class Multiplicacion
    {
        public int resultado;
        public Multiplicacion(int num1, int num2)
        {
            int resultado = num1 * num2;
            Console.WriteLine(resultado);
        }
    }
}
