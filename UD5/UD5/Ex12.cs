using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    public class Ex12
    {
        public void Menu()
        {
            int[] num_array = new int[10];
            float media = 0;
            for (int i = 0; i < num_array.Length; i++)
            {
                num_array[i] = i;
                media += num_array[i];
            }
            media /= num_array.Length;
            Console.WriteLine("La media de un array de 10 posiciones es " + media);
        }
    }
}
