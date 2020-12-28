using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    public class Ex9
    {
        public void Menu()
        {
            int[] num_array = new int[5];
            for (int i = 0; i < num_array.Length; i++)
            {
                Console.WriteLine("Introduce un numero para la posicion " + i);
                num_array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < num_array.Length; i++)
            {
                Console.WriteLine(num_array[i]);
            }
        }
    }
}
