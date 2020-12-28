using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    public class Ex17
    {
        protected int[] num_array = new int[10];
        public void Menu()
        {
            RellenarArray();
            MostrarArray();
        }

        void RellenarArray()
        {
            for (int i = 0; i < num_array.Length; i++)
            {
                Console.WriteLine("Introduce un valor para el indice " + i);
                num_array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        void MostrarArray()
        {
            for (int i = 0; i < num_array.Length; i++)
            {
                Console.WriteLine("El valor para el indice {0} es {1}", i, num_array[i]);
            }
        }
    }
}
