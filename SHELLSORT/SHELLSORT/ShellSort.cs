using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHELLSORT
{
    class ShellSort
    {
        public void ShellSorting(int[] vector, int tamño)
        {
            int i, j, division, auxiliar;
            division = tamño / 2;
            while (division > 0)
            {
                for (i = 0; i < tamño; i++)
                {
                    j = i;
                    auxiliar = vector[i];
                    while ((j >= division) && (vector[j - division] < auxiliar))
                    {
                        vector[j] = vector[j - division];
                        j = j - division;
                    }
                    vector[j] = auxiliar;
                }
                if (division / 2 != 0)
                    division = division / 2;
                else if (division == 1)
                    division = 0;
                else
                    division = 1;
            }
        }

        public void Imprimir(int[] vector)
        {
            foreach (int item in vector)
            {
                Console.Write(item + " ");
            };
            Console.WriteLine();
        }
        public void Proceso()
        {
            int tamaño = 0;
            Console.Write("Ingrese la cantidad de numeros: ");
            tamaño = Int16.Parse(Console.ReadLine());
            int[] vector = new int[tamaño];
            for (int i = 0; i < tamaño; i++)
            {
                Console.Write("Ingrese el numero {0}:", i + 1);
                vector[i] = Int16.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nVector sin ordenar :");
            Imprimir(vector);
            ShellSorting(vector, tamaño);
            Console.WriteLine("Vector ordenado :");
            Imprimir(vector);
            Console.ReadKey();
        }
    }
}
