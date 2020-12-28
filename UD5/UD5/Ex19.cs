using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    public class Ex19
    {
        public void Menu()
        {
            int longitud = 0;
            int rand_min = 0;
            int rand_max = 0;
            Console.WriteLine("¿Que longitud quieres que sea la array?");
            longitud = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dime un numero más pequeño que el siguiente para generar el random");
            rand_min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dime un numero más grande que el anterior para generar el random");
            rand_max = Convert.ToInt32(Console.ReadLine());
            int[] primo_array = rellenarArray(rand_min,rand_max,longitud);
            mostrarContenidoArray(primo_array);
        }

        private int generarRandom(int min, int max)
        {
            Random num_random = new Random();
            return num_random.Next(min, max);
        }

        bool Primo(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        int[] rellenarArray(int min, int max, int longitud_array)
        {
            int[] random_Array = new int[longitud_array];
            bool correcto = false;
            for (int i = 0; i < random_Array.Length; i++)
            {
                correcto = false;
                while (!correcto)
                {
                    random_Array[i] = generarRandom(min, max);
                    correcto = Primo(random_Array[i]);
                }
            }

            return random_Array;
        }
        void mostrarContenidoArray(int[] num_array)
        {
            int max  = 0;
            int max_pos = 0;
            for (int i = 0; i < num_array.Length; i++)
            {
                Console.WriteLine("El numero en la posición {0} es {1}", i, num_array[i]);
                if(max < num_array[i])
                {
                    max = num_array[i];
                    max_pos = i;
                }
            }
            Console.WriteLine("El numero más alto es {0} y está en la posición {1}", max, max_pos);
        }
    }
}
