using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.BiblioClases
{
    public class OperacionesAritmeticas
    {
        public float suma(float a, float b)
        {
            return a + b;
        }

        public float resta(float a, float b)
        {
            return a - b;
        }
        public float multiplicacion (float a, float b)
        {
            return a * b;
        }
        public void division(float a, float b)
        {
            
            try
            {
                Console.WriteLine(a / b);
                
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Division of {0} by zero.", a);
                
            }
            
            
            
        }

    }
}
