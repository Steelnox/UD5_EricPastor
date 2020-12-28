using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    public class Ex20
    {
        public void Menu()
        {
            int longitud = 0;
            Console.WriteLine("Dame la longitud de las arrays");
            longitud = Convert.ToInt32(Console.ReadLine());
            int[] array_num1 = rellenarArray(0, 10, longitud);
            int[] array_num2 = array_num1;
            array_num1 = new int[longitud];
            array_num1 = rellenarArray(0, 10, longitud);
            int[] array_num3 = multiplicacionArray(array_num1, array_num2);
            Console.WriteLine("Array 1");
            mostrarContenidoArray(array_num1);
            Console.WriteLine("Array 2");
            mostrarContenidoArray(array_num2);
            Console.WriteLine("Array 3");
            mostrarContenidoArray(array_num3);
        }

        private int generarRandom(int min, int max)
        {
            Random num_random = new Random();
            return num_random.Next(min, max);
        }

        int[] rellenarArray(int min, int max, int longitud_array)
        {
            int[] random_Array = new int[longitud_array];
            for (int i = 0; i < random_Array.Length; i++)
            {
                random_Array[i] = generarRandom(min, max);
            }
            return random_Array;
        }

        int[] multiplicacionArray(int[] array1, int[] array2)
        {
            int[] mult_array = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                mult_array[i] = array1[i] * array2[i];
            }
            return mult_array;
        }

        void mostrarContenidoArray(int[] num_array)
        {
            for (int i = 0; i < num_array.Length; i++)
            {
                Console.WriteLine("El numero en la posición {0} es {1}", i, num_array[i]);
            }
        }
    }
}
