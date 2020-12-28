using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    public class Ex10
    {
        public void Menu()
        {
            int[] tabla = new int[11];
            int num = 0;
            Console.WriteLine("Introduce el numero con el cual quieres crear la tabla");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < tabla.Length; i++)
            {
                tabla[i] = num * i;
                Console.WriteLine(num + " * " + i + " = " + tabla[i]);
            }
        }   
    }
}
