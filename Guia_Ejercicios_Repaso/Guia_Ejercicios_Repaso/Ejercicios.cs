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
    }
}
