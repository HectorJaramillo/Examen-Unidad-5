using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbuja
{
    public class Proceso
    {
        public void Burbuja()
        {
            int tamaño, temporal;//VARIABLE DONDE SE ALMACENARA TEMPORALMENTE UN NUMERO          
            Console.WriteLine("Ingrese la cantidad de numeros que desea capturar:");
            tamaño = int.Parse(Console.ReadLine());
            int[] Burbuja = new int[tamaño];//ARREGLO DE NUMEROS
            for (int i = 0; i < tamaño; i++)
            {
                Console.Write("Ingrese un numero: ");
               int auxiliar  = int.Parse(Console.ReadLine());//PIDE DATOS AL USUARIO DEPENDIENDO DE LA CANTIDAD DE NUMEROS
                while (auxiliar > 2 || auxiliar < 0) // Ciclo while para preguntar el numero hasta que se ingrese el correcto
                {
                    Console.WriteLine("\nIngrese unicamente valores de 0 A 2");
                    Console.Write("Ingrese un numero: ");
                    auxiliar = Int32.Parse(Console.ReadLine());
                }
                Burbuja[i] = auxiliar;
            }
            //INICIO DEL METODO BURBUJA
            for (int i = 1; i < Burbuja.Length; i++)
            {
                for (int j = 0; j < Burbuja.Length - 1; j++)
                {
                    if (Burbuja[i] < Burbuja[j])//CONDICIONAL SI LA POSICION DEL ARREGLO BURBUJA I ES MENOR A LA POSICION J
                    {
                        temporal = Burbuja[j];//SE ALMACENA EL CONTENIDO DE BURBUJA[J] EN LA VARIABLE TEMPORAL
                        Burbuja[j] = Burbuja[i];//SE ALMACENA EL CONTENIDO DE BURBUJA[I] EN BURBUJA[J]
                        Burbuja[i] = temporal;//SE ALMACENA EL CONTENIDO DE VARIABLE TEMPORAL EN LA BURBUJA[I]
                    }
                }
            }
            for (int i = 0; i < Burbuja.Length; i++)//CICLO PARA IMPRIMIR EL ARREGLO YA ORDENADO
            {
                Console.WriteLine("{0}.- {1}", i + 1, Burbuja[i]);
            }
            Console.ReadKey(true);
        }
    }
}
