using System;

namespace EjercicioCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string decision;
            do
            {
                int primerValor, segundoValor;
                string operacion;


                Console.Write("Ingrese un número: ");
                primerValor = int.Parse(Console.ReadLine());

                Console.Write("Elija una operación: ");
                operacion = Console.ReadLine();

                Console.Write("Ingrese otro número: ");
                segundoValor = int.Parse(Console.ReadLine());

                switch (operacion)
                {
                    case "+":
                        Console.Write("Su resultado es: " + Calculadora.Sumar(primerValor, segundoValor));
                        break;
                    case "-":
                        Console.Write("Su resultado es: " + Calculadora.Restar(primerValor, segundoValor));
                        break;
                    case "*":
                        Console.Write("Su resultado es: " + Calculadora.Multiplicar(primerValor, segundoValor));
                        break;
                    case "/":
                        Console.Write("Su resultado es: " + Calculadora.Dividir(primerValor, segundoValor));
                        break;
                }

                Console.ReadKey();
                Console.Clear();
                Console.Write("Desea realizar otra operación? s/n");
                decision = Console.ReadLine();

            }
            while (decision.ToLower() == "s");

        }
    }
}
