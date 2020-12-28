using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    public class Ex4
    {
        public void Menu()
        {
            int num = 0;
            Console.WriteLine("Introduce el numero el cual quieres que calcule el factorial");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El factorial del numero {0} es {1}", num, Factorial(num));
        }

        int Factorial(int num)
        {
            int resultado = 1;
            for (int i = 1; i <= num; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}
