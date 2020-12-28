using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    public class Ex3
    {
        public void Menu()
        {
            int num = 0;

            Console.WriteLine("Introduce un numero y te diré si es un numero primo o no");
            num = Convert.ToInt32(Console.ReadLine());
            if (numPrimo(num))
            {
                Console.WriteLine("El numero {0} es un numero primo", num);
            }
            else
            {
                Console.WriteLine("El numero {0} no es un numero primo", num);
            }
        }

        bool numPrimo(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
