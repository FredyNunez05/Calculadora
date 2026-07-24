using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace LibreriaOperadores
    {
        public class Division
        {
            public float resultado;
            public Division(float num1, float num2)
            {
                resultado =num1 / num2;
                Console.WriteLine(resultado);
            }
        }
    }
