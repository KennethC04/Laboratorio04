using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public class Ejercicio03
    {
        public string Sumar(string num1, string num2) 
        {
            string result = (int.Parse(num1) + int.Parse(num2)).ToString();
            return result;
        }
    }
}
