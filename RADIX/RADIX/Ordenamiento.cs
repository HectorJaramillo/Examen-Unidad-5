using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RADIX
{
    public class Ordenamiento
    {
        public void Arreglando()
        {
            int[] vector = new int[80];
            Random r = new Random();
            int random = 0;
            int auxiliar = 0;
            for (int i = 0; i < 80; i++)
            {
                random = r.Next(1, 90);
                bool continuar = false;
                while (!continuar)
                {
                    for (int j = 0; j <= auxiliar; j++)
                    {
                        if (random == vector[j])
                        {
                            continuar = true;
                            j = auxiliar;
                        }
                    }
                    if (continuar)
                    {
                        random = r.Next(1, 120);
                        continuar = false;
                    }
                    else
                    {
                        continuar = true;
                        vector[auxiliar] = random;
                        auxiliar++;
                    }
                }
            }
            new RADIX(vector).RadixSort();//LLAMADA DE LOS METODOS
            Console.ReadKey(true);
        }
    }
}
