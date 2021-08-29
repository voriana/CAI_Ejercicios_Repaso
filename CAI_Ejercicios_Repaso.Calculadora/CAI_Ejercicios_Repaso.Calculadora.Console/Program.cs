using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.BiblioClases;

namespace CAI_Ejercicios_Repaso.Calculadora.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacionesAritmeticas operaciones = new OperacionesAritmeticas();
            Validacion validar = new Validacion();
            bool flag = false;
            float num1=0;
            float num2=0;
            int operacionArealizar;
            do
            {
                Console.WriteLine("Bienvenido a la calculadora basica");
                operacionArealizar = Validacion.OpcionOperacion();

                if (operacionArealizar == 1 || operacionArealizar == 2 || operacionArealizar == 3 || operacionArealizar == 4 )
                {
                
               
                    num1= Validacion.SolicitarNumero();
                    num2 = Validacion.SolicitarNumero();

                    if (operacionArealizar == 1)
                    {
                        Console.WriteLine(operaciones.suma(num1, num2));

                    }
                    else if (operacionArealizar == 2)
                    {

                        Console.WriteLine(operaciones.resta(num1, num2));

                    }
                    else if (operacionArealizar == 3)
                    {

                        Console.WriteLine(operaciones.multiplicacion(num1, num2));
                    }
                    else if (operacionArealizar == 4)
                    {

                        operaciones.division(num1, num2);
                       
                     
                    }

                }else if (operacionArealizar == 9)
                {
                    flag = Validacion.ConfirmarSalida();
                }

            } while (operacionArealizar != 9|| flag==false);
            Console.WriteLine("Saliendo del sistema");
            Console.ReadKey();
            
        }

        
    }
    
}

