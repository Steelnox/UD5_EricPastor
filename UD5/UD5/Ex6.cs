using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    public class Ex6
    {
        public void Menu()
        {
            int num = 0;
            Console.WriteLine("Dame un numero que quieras saber el numero de cifras que tiene");
            num = Convert.ToInt32(Console.ReadLine());
            while (num < 0)
            {
                Console.WriteLine("Numero incorrecto. Introduce un numero positivo");
                num = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("El numero {0} tiene {1} digitos", num, numCount(num));

        }

        int numCount(int num)
        {
            string count = Convert.ToString(num);
            return count.Length;
        }
    }
}
