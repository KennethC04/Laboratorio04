using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public class Ejercicio04
    {
        public int[] CalcularBilletes(int cantidad, int[] billetes)
        {
            int[] resultado = new int[billetes.Length];

            for (int i = 0; i < billetes.Length; cantidad %= billetes[i], resultado[i++] = cantidad / billetes[i]) ;

            Console.WriteLine("Resultado:");
            for (int i = 0; i < resultado.Length; Console.WriteLine(billetes[i++] + ": " + resultado[i - 1])) ;

            return resultado;
        }
    }
}
