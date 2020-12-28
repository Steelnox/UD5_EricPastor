using System;

namespace UD5
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            Ex1 ex1 = new Ex1();
            Ex2 ex2 = new Ex2();
            Ex3 ex3 = new Ex3();
            Ex4 ex4 = new Ex4();
            Ex5 ex5 = new Ex5();
            Ex6 ex6 = new Ex6();
            Ex7 ex7 = new Ex7();
            Ex8 ex8 = new Ex8();
            Ex9 ex9 = new Ex9();
            Ex10 ex10 = new Ex10();
            Ex11 ex11 = new Ex11();
            Ex12 ex12 = new Ex12();
            Console.WriteLine("Ejercicios de la Unidad 5");
            Console.WriteLine("Escribe el numero del ejercicio que quieres ver (del 1 al 21)");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    ex1.Menu();
                    break;
                case "2":
                    ex2.Menu();
                    break;
                case "3":
                    ex3.Menu();
                    break;
                case "4":
                    ex4.Menu();
                    break;
                case "5":
                    ex5.Menu();
                    break;
                case "6":
                    ex6.Menu();
                    break;
                case "7":
                    ex7.Menu();
                    break;
                case "8":
                    ex8.Menu();
                    break;
                case "9":
                    ex9.Menu();
                    break;
                case "10":
                    ex10.Menu();
                    break;
                case "11":
                    ex11.Menu();
                    break;
                case "12":
                    ex12.Menu();
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta. Vuelve a intentarlo más tarde");
                    break;
            }
        }

    }
}
