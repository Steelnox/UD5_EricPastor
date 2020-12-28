using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    public class Ex13
    {
        public void Menu()
        {
            int num = 0;
            Console.WriteLine("Que longitud de array desea?");
            num = Convert.ToInt32(Console.ReadLine());
            generadorRandomArray(num);
        }
        void generadorRandomArray(int longitud)
        {
            int[] random_array = new int[longitud];
            Random num_random = new Random();
            for (int i = 0; i < random_array.Length; i++)
            {
                random_array[i] = num_random.Next(1, 10);
                Console.WriteLine("El numero random de la posición {0} es {1}", i, random_array[i]);
            }
        }
    }
}
