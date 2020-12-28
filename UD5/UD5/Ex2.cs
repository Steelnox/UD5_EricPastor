using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    public class Ex2
    {
        public void Menu()
        {
            int cantidad = 0;
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Que cantidad de numeros aleatorios quieres que genere");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el primer numero entre el cual quieres que esté el aleatorio (este numero estará incluido)");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el segundo numero entre el cual quieres que esté el aleatorio (este numero no estará incluido)");
            num2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine("El aleatorio numero {0} es {1}", i, RandomGenerator(num1,num2));
            }
        }

        int RandomGenerator(int rango1, int rango2)
        {
            Random num_alea = new Random();
            return num_alea.Next(rango1, rango2);
        } 
    }
}
