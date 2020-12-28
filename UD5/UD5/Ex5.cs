using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace UD5
{
    public class Ex5
    {
        public void Menu()
        {
            int num;
            Console.WriteLine("Introduce un numero el cual quieres que cambie a binario ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El numero {0} en binario es {1}", num, Binario(num));
        }
        string Binario(int original_num)
        {
            string num_bin = "";
            List<string> bin_list = new List<string>();
            while(original_num > 0)
            {
                bin_list.Add(Convert.ToString(original_num % 2));
                original_num /= 2;
            }
            string[] bin_array = bin_list.ToArray();
            for (int i = bin_array.Length - 1; i >= 0; i--)
            {
                num_bin += bin_array[i];
            }
            return num_bin;
        }
    }
}
