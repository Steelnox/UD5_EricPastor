using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    public class Ex14
    {
        public void Menu()
        {
            int num = 0;
            int comprobar = 0;
            Console.WriteLine("Que longitud de array desea?");
            num = Convert.ToInt32(Console.ReadLine());
            int [] numRandom_array = generadorRandomArray(num);
            Console.WriteLine("Dime un numero para comprobar que este en la array");
            comprobar = Convert.ToInt32(Console.ReadLine());
            if (comprobadorArray(comprobar, numRandom_array))
            {
                Console.WriteLine("El numero si esta en la array");
            }
            else
            {
                Console.WriteLine("El numero no esta en la array");
            }
        }
        int[] generadorRandomArray(int longitud)
        {
            int[] random_array = new int[longitud];
            Random num_random = new Random();
            for (int i = 0; i < random_array.Length; i++)
            {
                random_array[i] = num_random.Next(1, 10);
                Console.WriteLine("El numero random de la posición {0} es {1}", i, random_array[i]);
            }
            return random_array;
        }

        bool comprobadorArray(int num, int[] random_array)
        {
            for (int i = 0; i < random_array.Length; i++)
            {
                if(num == random_array[i])
                {
                    return true;
                }
            }
            return false;
        }

    }
}
