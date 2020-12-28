using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    public class Ex7
    {
        public void Menu()
        {
            float euros = 0;
            string moneda = "";
            Console.WriteLine("Introduce la cantidad en euros");
            euros = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Introduce que moneda quieres cambiar");
            Console.WriteLine("Los cambios son: libras, dolares y yenes");
            moneda = Console.ReadLine();
            cambioMoneda(euros, moneda);
        }

        void cambioMoneda(float euros, string tipo)
        {
            float resultado_final = 0;
            switch (tipo)
            {
                case "libras":
                    resultado_final = 0.86f * euros;
                    Console.WriteLine("La cantidad de {0} euros son {1} libras", euros, resultado_final);
                    break;
                case "dolares":
                    resultado_final = 1.28611f * euros;
                    Console.WriteLine("La cantidad de {0} euros son {1} dolares", euros, resultado_final);
                    break;
                case "yenes":
                    resultado_final = 129.852f * euros;
                    Console.WriteLine("La cantidad de {0} euros son {1} yenes", euros, resultado_final);
                    break;
                default:
                    Console.WriteLine("Tipo de moneda incorrecta. Vuelve a intentarlo más tarde");
                    break;
            }
        }
    }
}
