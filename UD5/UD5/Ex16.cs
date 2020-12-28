using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    public class Ex16
    {
        public void Menu()
        {
            int[] num_array = new int[10];
            int[] capicua_array = { 1, 0, 0, 1 };
            for (int i = 0; i < num_array.Length; i++)
            {
                num_array[i] = i;
            }

            Console.WriteLine("La array con valores:");
            for (int i = 0; i < num_array.Length; i++)
            {
                if (i < num_array.Length - 1)
                {
                    Console.Write(num_array[i] + ", ");

                }
                else
                {
                    Console.WriteLine(num_array[i]);
                }
            }
            if (Capicua(num_array))
            {
                Console.WriteLine("Es capicua");
            }

            else
            {
                Console.WriteLine("No es capicua");
            }

            Console.WriteLine("La array con valores:");
            for (int i = 0; i < capicua_array.Length; i++)
            {
                if (i < capicua_array.Length - 1)
                {
                    Console.Write(capicua_array[i] + ", ");

                }
                else
                {
                    Console.WriteLine(capicua_array[i]);
                }
            }

            if (Capicua(capicua_array))
            {
                Console.WriteLine("Es capicua");
            }

            else
            {
                Console.WriteLine("No es capicua");
            }

        }

        bool Capicua(int[] esCapicua_array)
        {
            int j = 0;
            for (int i = esCapicua_array.Length - 1; i >= 0; i--)
            {
                if(esCapicua_array[i] != esCapicua_array[j])
                {
                    return false;
                }
                j++;
            }
            return true;
        }
    }
}
