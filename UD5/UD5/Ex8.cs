using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    public class Ex8
    {
        public void Menu()
        {
            int[] num_array = new int[10];
            for (int i = 0; i < num_array.Length; i++)
            {
                num_array[i] = i;
                Console.WriteLine(num_array[i]);
            }
        }
    }
}
