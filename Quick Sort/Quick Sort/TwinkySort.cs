using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    public class TwinkySort
    {
        List<int> vector;
        public void Letrero()
        {
            List<char> Letras = new List<char>();
            vector=new List<int>();
            string oracion = "lorem ipsum dolor sit amet, consectetur adipiscing elit. fusce varius, augue vitae tincidunt viverra, sem felis bibendum nisl, id cursus diam leo sit amet urna. duis ac massa est.";
            foreach (char letra in oracion)
            {
                Letras.Add(letra);
            }
            
            for (int i = 0; i < Letras.Count; i++)
            {
                switch (Letras[i])
                {
                    case 'a':
                        vector.Add(1);
                        break;
                    case 'b':
                        vector.Add(2);
                        break;
                    case 'c':
                        vector.Add(3);
                        break;
                    case 'd':
                        vector.Add(4);
                        break;
                    case 'e':
                        vector.Add(5);
                        break;
                    case 'f':
                        vector.Add(6);
                        break;
                    case 'g':
                        vector.Add(7);
                        break;
                    case 'h':
                        vector.Add(8);
                        break;
                    case 'i':
                        vector.Add(9);
                        break;
                    case 'j':
                        vector.Add(10);
                        break;
                    case 'k':
                        vector.Add(11);
                        break;
                    case 'l':
                        vector.Add(12);
                        break;
                    case 'm':
                        vector.Add(13);
                        break;
                    case 'n':
                        vector.Add(14);
                        break;
                    case 'o':
                        vector.Add(15);
                        break;
                    case 'p':
                        vector.Add(16);
                        break;
                    case 'q':
                        vector.Add(17);
                        break;
                    case 'r':
                        vector.Add(18);
                        break;
                    case 's':
                        vector.Add(19);
                        break;
                    case 't':
                        vector.Add(20);
                        break;
                    case 'u':
                        vector.Add(21);
                        break;
                    case 'v':
                        vector.Add(22);
                        break;
                    case 'w':
                        vector.Add(23);
                        break;
                    case 'x':
                        vector.Add(24);
                        break;
                    case 'y':
                        vector.Add(25);
                        break;
                    case 'z':
                        vector.Add(26);
                        break;
                    case 'ñ':
                        vector.Add(27);
                        break;
                    default:
                        break;
                }
            }
            for (int i = 0; i < vector.Count; i++)
            {
                vector[i] = vector[i];
            }

        }

        public void QuickSort(List<int> vector, int primero, int ultimo)//METODO QUICKSORT
        {//PIDE UN ARREGLO, POSICION INICIAL DEL VECTOR Y LA POSICION
            int i, j, central;//SEÑALADORES DEL METODO
            int pivote;
            central = (primero + ultimo) / 2;//CALCULO DE LA POSICION CENTRAL DEL ARREGLO AL SER DE TIPO INT SE REDONDEA
            pivote = vector[central];//VALOR DE LA POSICION CENTRAL DEL VECTOR
            i = primero;
            j = ultimo;

            do//IMPLEMENTACION DEL ORDENAMIENTO
            {
                while (vector[i] < pivote) i++;//MIENTRA EXISTA UN ELEMENTO MENOR QUE EL PIVOTE
                while (vector[j] > pivote) j--;//MIENTRA EXISTA UN ELEMENTO MAYOR QUE EL PIVOTE

                if (i <= j)//SI I ES MENOR O IGUAL QUE J
                {
                    int temporal;//VARIABLE DE ALMACENAMIENTO TEMPORAL
                    temporal = vector[i];//LA POSICION I DEL VECTOR SE GUARDA EN TEMPORAL
                    vector[i] = vector[j];//LA POSICION J DEL VECTOR SE GUARDA EN LA POSICION I
                    vector[j] = temporal;//EL VALOR GUARDADO EN TEMPORAL SE GUARDA EN LA POSICION J DEL VECTOR
                    i++;//CONTADORES +1
                    j--;

                }
            } while (i <= j);//SI I ES MENOR IGUAL QUE J

            if (primero < j)//SI PRIMERO ES MENOR QUE J
            {
                QuickSort(vector, primero, j);//LLAMADA RECURSIVA DEL METODO QUIKSORT
            }
            if (i < ultimo)//SI I ES MENOR QUE ULTIMO
            {
                QuickSort(vector, i, ultimo);//LLAMADA RECURSIVA DEL METODO QUIKSORT
            }
        }

        public void Mostrar()//METODO PARA IMPRIMIR LOS VECTORES YA ORDENADOS
        {
            Letrero();
            QuickSort(vector, 0, vector.Count - 1);//LLAMADA AL METODO QUICKSORT PARA CADA VECTOR
            Console.WriteLine("Vector con numeros");
            for (int i = 0; i < vector.Count; i++)
            {

                Console.Write("{0}, ", vector[i]);
            }
            string abecedario = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine("\nVector con letras");
            for (int i = 0; i < vector.Count; i++)
            {
                Console.Write("{0}, ", abecedario[vector[i]-1]);
            }

            Console.ReadKey(true);
        }
    }
}
