using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaOperadores
{
    public class Resta
    {
        public int resultado;
        public Resta(int num1, int num2)
        {
            int resultado = num1 - num2;
            Console.WriteLine(resultado);
        }
    }
}
