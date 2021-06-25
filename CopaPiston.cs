using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace threads
{
    class CopaPiston
    {
        public CopaPiston()
        {
        }

        Random r = new Random();
        

        public void Liebre()
        {
            int posicion = 1;
            while (posicion != 70)
            {
                int probabilidad = r.Next(1, 101);
                if (probabilidad <= 20)
                {
                    posicion = CalcularPosicion(posicion, 0);
                    Console.WriteLine("L: duerme, POSICIÓN {0}", posicion);
                }
                else if (probabilidad > 20 && probabilidad <= 40)
                {
                    posicion = CalcularPosicion(posicion, 9);
                    Console.WriteLine("L: gran salto, POSICIÓN {0}", posicion);
                }
                else if (probabilidad > 40 && probabilidad <= 50)
                {
                    posicion = CalcularPosicion(posicion, -12);
                    Console.WriteLine("L: resbalón grande, POSICIÓN {0}", posicion);
                }
                else if (probabilidad > 50 && probabilidad <= 80)
                {
                    posicion = CalcularPosicion(posicion, 1);
                    Console.WriteLine("L: pequeño salto, POSICIÓN {0}", posicion);
                }
                else
                {
                    posicion = CalcularPosicion(posicion, -2);
                    Console.WriteLine("L: resbalón pequeño, POSICIÓN {0}", posicion);
                }
                Thread.Sleep(1000);
            }
            if (posicion == 70) Console.WriteLine("LIEBRE llegó a la meta");
            Console.ReadKey();
        }

        public void Tortuga()
        {
            int posicion = 1;
            while (posicion != 70)
            {
                int probabilidad = r.Next(1, 101);
                if (probabilidad <= 50)
                {
                    posicion = CalcularPosicion(posicion,3);
                    Console.WriteLine("T: avance rápido, POSICIÓN {0}", posicion);
                }
                else if (probabilidad > 50 && probabilidad <= 70)
                {
                    posicion = CalcularPosicion(posicion, -6);
                    Console.WriteLine("T: resbaló, POSICIÓN {0}", posicion);
                }
                else
                {
                    posicion = CalcularPosicion(posicion, 1);
                    Console.WriteLine("T: avance lento, POSICIÓN {0}", posicion);
                }
                Thread.Sleep(1000);
            }
            if (posicion == 70) Console.WriteLine("TORTUGA llegó a la meta");
            Console.ReadKey();
        }

        public int CalcularPosicion(int posicion, int desplazamiento)
        {
            int resultado = posicion + desplazamiento;
            if (resultado < 1)
            {
                resultado = 1;
            }
            if (resultado > 70)
            {
                resultado = 70;
            }
            return resultado;
        }
    }
}
