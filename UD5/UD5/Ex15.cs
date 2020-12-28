using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    public class Ex15
    {
        public void Menu()
        {
            int[] num_array = new int[10];
            int[] inverse_array = new int[10];
            int j = 0;
            for (int i = 0; i < num_array.Length; i++)
            {
                num_array[i] = i;
            }
            for (int i = num_array.Length-1; i >= 0; i--)
            {
                inverse_array[j] = num_array[i];
                j++;
            }

            for (int i = 0; i < num_array.Length; i++)
            {
                Console.WriteLine("El valor en la posición {0} de la array original es {1} y de la inversa es {2}", i, num_array[i], inverse_array[i]);
            }
        }
    }
}
