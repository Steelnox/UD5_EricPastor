using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    public class Ex21
    {
        public void Menu()
        {
            int longitud = 0;
            int num_comprobar = 0;
            Console.WriteLine("¿Que tamaño quieres que tenga la array?");
            longitud = Convert.ToInt32(Console.ReadLine());
            int[] num_array = rellenarArray(1, 300, longitud);
            Console.WriteLine("¿Que numero quieres comprobar?");
            num_comprobar = Convert.ToInt32(Console.ReadLine());
            comprobarNum(num_comprobar, num_array);
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

        void comprobarNum(int num, int[] num_array)
        {
            for (int i = 0; i < num_array.Length; i++)
            {
                if(num_array[i] % 10 == num)
                {
                    Console.WriteLine(num_array[i]);
                }
            }
        }
    }
}
