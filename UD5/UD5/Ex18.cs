using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    public class Ex18
    {
        protected int longitud_array = 0;

        public void Menu()
        {
            const int num_min = 0;
            const int num_max = 9;
            Console.WriteLine("¿Que longitud quieres que tenga el array?");
            longitud_array = Convert.ToInt32(Console.ReadLine());
            int[] num_array = rellenarArray(num_min, num_max);
            mostrarContenidoArray(num_array);
        }

        private int generarRandom(int min, int max)
        {
            Random num_random = new Random();
            return num_random.Next(min, max);
        }

        int[] rellenarArray(int min, int max)
        {
            int[] random_Array = new int[longitud_array];
            for (int i = 0; i < random_Array.Length; i++)
            {
                random_Array[i] = generarRandom(min, max);
            }

            return random_Array;
        }

        void mostrarContenidoArray(int [] num_array)
        {
            int resultado = 0;
            for (int i = 0; i < num_array.Length; i++)
            {
                Console.WriteLine("El numero en la posición {0} es {1}", i, num_array[i]);
                resultado += num_array[i];
            }
            Console.WriteLine("La suma total de la array es " + resultado);
        }

    }
}
