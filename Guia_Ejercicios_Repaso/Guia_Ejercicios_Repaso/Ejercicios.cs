using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Ejercicios_Repaso
{
    class Ejercicios
    {
        public void ej01()
        {

            string registro = "95490443";
            int hasta = Convert.ToInt32(registro.Substring(5));

            for (int i = 1; i <= hasta; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i + "- Foo Bar");

                    }
                    else
                    {
                        Console.WriteLine(i + "- Foo");
                    }
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + "- Bar");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

        }

        public void Ej02()
        {
            int contador = 0;
            int desde = 1;
            string registro = "95490443";
            string reg = registro.Substring(5);
            int hasta = Convert.ToInt32(reg);
            bool flag = false;

            while (desde <= hasta)
            {
                for (int i = 1; i <= desde; i++)
                {
                    if (desde % i == 0)
                    {
                        contador++;

                    }
                    if (desde % 3 == 0)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }

                }

                if (contador <= 2)
                {
                    if (flag)
                    {

                        Console.WriteLine(desde + "- Es primo y divisible por 3");

                    }
                    else
                    {
                        Console.WriteLine(desde + "- Es primo");
                    }
                }

                else if (flag)
                {
                    Console.WriteLine(desde + "- Es divisible por 3");
                }
                else
                {
                    Console.WriteLine(desde + "- ");
                }

                contador = 0;
                desde++;



            }

        }
         public void Ej03()
         {
            /*Ejercicio III 
                Crear una aplicación que indique, cuando el usuario ingresa una palabra, si ésta es un 
                palíndromo.
            */

            string palabra, inversa;
            Console.WriteLine("Ingrese una palabra");
            palabra = Console.ReadLine();
            inversa ="";

            for(int x= palabra.Length-1; x >= 0; x--)
            {
                inversa = inversa+palabra[x].ToString();
            }

            if (palabra == inversa)
            {
                Console.WriteLine("La palabra es Palindromo");
            }else
            {
                Console.WriteLine("No es Palindromo");
            }
         }

        public void Ej04()
        {
            /*Ejercicio IV
            Crear una aplicación que indique, cuando el usuario ingresa dos palabras, si éstas son 
            un anagrama. 
            Nota: Anagrama son palabras que reordenando sus letras forman una nueva, como 
            "roma" y "amor".*/

            string palabra1, palabra2;

            Console.WriteLine("Ingrese la primera palabra");
            palabra1 = Console.ReadLine();
            string palabra1Ordenada = new string(palabra1.OrderBy(x => x).ToArray());

            Console.WriteLine("Ingrese la segunda palabra");
            palabra2 = Console.ReadLine();
            string palabra2Ordenada = new string(palabra2.OrderBy(x => x).ToArray());

            if (palabra1Ordenada == palabra2Ordenada)
            {
                Console.WriteLine("Es un anagrama");
            }
            else
            {
                Console.WriteLine("No es un anagrama");
            }
        }
        public void Ej05()
        {
            /*
             * Crear una aplicación que, cuando el usuario ingresa un número de 5 cifras, lo invierta y 
               muestre por pantalla “El número invertido es: *nnnnn*”. Por ejemplo, si el usuario 
               ingresa “12345”, mostrará por pantalla “54321”
            */


            Console.WriteLine("Ingrese un numero de 5 cifras");
            int numero = Convert.ToInt32(Console.ReadLine());
            int invertido = invierteNro(numero);
            Console.WriteLine("El numero invertido es: " + invertido);

            

            

        }
        private int invierteNro(int num)

        {
            int nroInvertido = 0;
            while (num > 0)
            {
                nroInvertido = nroInvertido * 10+(num % 10);
                num = num / 10;
            }

            return nroInvertido; 

        }

        public void Ej06()
        {
            /*Ejercicio VI 
            Crear una aplicación que, cuando el usuario ingrese dos números, realice la operación 
            aritmética (a+b)*(a-b) e indique por pantalla el resultado. 
            */
           
            Console.WriteLine("Ingrese valor 1");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese valor 2");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            int resultado = calculoEjercio6(valor1,valor2);
            Console.WriteLine(resultado);


        }
        private int  calculoEjercio6(int a, int b)
        {
            int num;
            num = (a + b) * (a - b);

            return num;
        }
        
        public void Ej07()
        {
            /*
             * Ejercicio VII 
                Crear una aplicación que, cuando el usuario ingrese cinco números, indique cuál es 
                mayor, cuál es valor intermedio y cuál el menor.
            *
            */

            int[] numIngresados = new int [5];
            int min, med, max;

            for(int i = 0; i < numIngresados.Length; i++)
            {
                Console.WriteLine("Ingrese numero " +(i+1));
                numIngresados[i] = Convert.ToInt32(Console.ReadLine());

            }
            int[] ordenados = numIngresados.OrderBy(x => x).ToArray();
            
            min = ordenados[0];
            med = ordenados[2];
            max = ordenados[4];
            Console.WriteLine("Minimo: " + min);
            Console.WriteLine("Intermedio: " + med);
            Console.WriteLine("Maximo: " + max);
        }

        public void Ej08()
        {
            /*Ejercicio VIII 
            Crear una aplicación que, cuando el usuario ingrese una fecha, calcule la diferencia entre 
            ésta y el día de hoy, mostrando por pantalla "La diferencia de fechas es de *nnnnn* 
            días."*/

            DateTime fechaIngresada;
            Console.WriteLine("Ingrese Fecha [yyyy-mm-dd]:");
            fechaIngresada = Convert.ToDateTime(Console.ReadLine());
            double dias = (DateTime.Today - fechaIngresada).TotalDays;
            Console.WriteLine("dias de diferencia entre fechas: " + dias);
                
            }

    }
}
