using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.BiblioClases
{
    public class Validacion
    {

        public static int OpcionOperacion()
        {
            int opcion;
            bool flag = false;
            do
            {
                Console.WriteLine("Elegi que operacion desea realizar \n " +
                    "" +
                    "1-Suma \n 2-Resta \n 3-Multiplicacion \n 4-Division \n 9-Salir");
                
                opcion = Convert.ToInt32(SolicitarNumero());

                if (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4 || opcion == 9)
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Opcion invalida");
                }
            } while (flag == false);

            return opcion;
        }
        public static  float SolicitarNumero()
        {
            float nroIngresado;
            bool flag = false;
            do
            {
                Console.WriteLine("Por favor Ingrese un numero:");
                if (!Single.TryParse(Console.ReadLine(), out nroIngresado))
                {
                    Console.WriteLine("Debe ingresar un valor numerico");
                }
                else
                {
                    flag = true;
                }

            } while (flag==false);
            return nroIngresado;
        }
        public  static bool ConfirmarSalida()
        {
            bool flag;
            Console.WriteLine("Esta Opcion esta para salir del Sistema.\n  Esta seguro que desea salir? [S/N]");
            if (Console.ReadLine().Equals("S"))
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }
    }
}
