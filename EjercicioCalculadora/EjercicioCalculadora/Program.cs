using System;

namespace EjercicioCalculadora
{
    class Program
    {

        static int Suma(int a, int b)
        {
            int suma = a + b;
            return suma;
        }
        static int Resta(int a, int b)
        {
            int resta = a - b;
            return resta;
        }
        static int Multiplicacion(int a, int b)
        {
            int multiplicacion = a * b;
            return multiplicacion;
        }
        static int Division(int a, int b)
        {
            int division = a / b;
            return division;
        }
        
        static void Main()
        {
            try
            {
                int a, b;
                a = 5;
                b = 0;
                int c = a / b;
            }

            catch(Exception gustavo)
            {

                //throw gustavo;
            }

            int primerNumero, segundoNumero, operacion;
            string valorIngresado;
            Console.Write("Ingrese primer valor: ");
            valorIngresado = Console.ReadLine();
            if (!int.TryParse(valorIngresado, out primerNumero) || primerNumero < 0)
            {
                Environment.Exit(0);
            }

            Console.Write("Seleccione una opción: " + "\n");
            Console.Write("1) Suma" + "\n" + "2) Resta" + "\n" + "3) Multiplicación" + "\n" + "4) División" + "\n");
            operacion = int.Parse(Console.ReadLine());
            
            Console.Write("Ingrese segundo valor: ");
            valorIngresado = Console.ReadLine();

            if (!int.TryParse(valorIngresado, out segundoNumero) || segundoNumero < 0)
            {
                Environment.Exit(0);
            }


            switch (operacion)
            {
                case +:
                    Console.Write("La operación elegida es suma y el resultado es = " + Suma(primerNumero, segundoNumero));
                    break;
                case 2:
                    Console.Write("La operación elegida es resta y el resultado es = " + Resta(primerNumero, segundoNumero));
                    break;
                case 3:
                    Console.Write("La operación elegida es multiplicación y el resultado es = " + Multiplicacion(primerNumero, segundoNumero));
                    break;
                case 4:
                    Console.Write("La operación elegida es división y el resultado es = " + Division(primerNumero, segundoNumero));
                    break;
            }
            Console.ReadKey();
        }
    }
}
