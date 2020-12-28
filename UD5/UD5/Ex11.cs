using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    public class Ex11
    {
        public void Menu()
        {
            int[] num_array = new int[10];
            int resultado = 0;
            for (int i = 0; i < num_array.Length; i++)
            {
                num_array[i] = i;
                resultado += num_array[i];
            }
            Console.WriteLine("La suma total de un array de 10 es " + resultado);
        }
    }
}
