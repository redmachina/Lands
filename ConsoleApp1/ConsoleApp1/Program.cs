using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamaño;
            Console.WriteLine("Introduce el tamaño del arreglo");
            tamaño = Convert.ToInt32( Console.ReadLine());


            int[] arreglo = new int [tamaño];

            Console.WriteLine("Introduce valores a la matriz");

            for (int i =0;i<= tamaño-1;i++) 
            {
                arreglo[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("  ");

            for (int j=0;j<=tamaño-1;j++)
            {
                Console.WriteLine(arreglo[j]);
            }



            /*
            for (int i = 0;i<=3;i++)
            {
                Console.Write("PERRO ");

                for (int j =0;j<=3;j++)
                {
                    Console.Write("gato");
                
                }

                Console.WriteLine(" ");
            }

            */

            /*
            int dato1 = 0, dato2 = 0, dato3 = 0;
            Console.WriteLine("Se Inicia la aplicacion");

            try
            {
                dato1++;
                dato3 = dato1 / dato2;
                dato2++;
                //otras sentancias
            }
            catch(System.DivideByZeroException e)
            {
                //Maneja la excepcion de divicion entre cero
                Console.WriteLine("Error" + e.Message);
                dato3 = dato1;
            }
            Console.WriteLine(dato1 + " "+ dato2+ " "+dato3);
            
            */

            /*
            int[] numero = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i= 0;i<10;i++) 
            {
                Console.WriteLine("valor de elemento"+ numero[i]);
            }


            */





            /*
            int falfil, calfil;
            int fila, columna;

            Console.WriteLine("Posicion del alfil");
            Console.Write(" fila ");
            falfil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Columna");
            calfil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for(fila=1; fila <=8; fila ++)
            {

                for (columna = 1; columna <= 8; columna++)
                {

                    if ((fila + columna == falfil + calfil) || (fila - columna == falfil - calfil))
                        Console.Write("*");
                    else if ((fila + columna) % 2 == 0)
                        Console.Write("b");
                    else
                        Console.Write("N");
                }
                Console.WriteLine();
            }

            */
        }
    }
}
