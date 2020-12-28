using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    public class Ex1
    {
        protected float resultado = 0;
        protected bool correcto = false;
        
        public void Menu()
        {
            string opcion = "";
            Console.WriteLine("Calculadora de areas");
            Console.WriteLine("Opción 1: Area circulo");
            Console.WriteLine("Opción 2: Area triangulo");
            Console.WriteLine("Opción 3: Area cuadrado");
            Console.WriteLine("Escoge que area quiere calcular poniendo el número de la opción");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("El area del circulo es " + Area_Circulo());
                    break;
                case "2":
                    Console.WriteLine("El area del triangulo es " + Area_Triangulo());
                    break;
                case "3":
                    Console.WriteLine("El area del cuadrado es " + Area_Cuadrado());
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta. Vuelve a intentarlo más tarde");
                    break;
            }
        }

        float Area_Circulo()
        {
            float radio = 0;
            Console.WriteLine("Introduce el radio del circulo para poder calcular el area");
            while (!correcto)
            {
                try
                {
                    radio = Convert.ToSingle(Console.ReadLine());
                    correcto = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Radio incorrecto. Vuelve a intentarlo.");
                }
            }
            resultado = Convert.ToSingle(Math.Pow(radio, 2) * Math.PI);
            return resultado;
        }

        float Area_Triangulo ()
        {
            float base_triangulo = 0;
            float altura_triangulo = 0;
            Console.WriteLine("Introduce la base del triangulo para poder calcular el area");
            while (!correcto)
            {
                try
                {
                    base_triangulo = Convert.ToSingle(Console.ReadLine());
                    correcto = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Base incorrecta. Vuelve a intentarlo.");
                }
            }
            correcto = false;
            Console.WriteLine("Introduce la altura del triangulo para poder calcular el area");
            while (!correcto)
            {
                try
                {
                    altura_triangulo = Convert.ToSingle(Console.ReadLine());
                    correcto = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Altura incorrecta. Vuelve a intentarlo");
                }
            }
            resultado = (base_triangulo * altura_triangulo) / 2;
            return resultado;
        }

        float Area_Cuadrado()
        {
            float lado = 0;
            Console.WriteLine("Introduce el lado del cuadrado para calcular el area");
            try
            {
                lado = Convert.ToSingle(Console.ReadLine());
                correcto = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Lado incorrecto. Vuelve a intentarlo");
            }
            resultado = lado * lado;
            return resultado;
        }
    }
}
