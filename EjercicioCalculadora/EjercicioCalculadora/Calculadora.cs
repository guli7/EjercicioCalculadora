using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCalculadora
{
    static class Calculadora
    {
        public static int Sumar(int primerValor, int segundoValor)
        {
            return primerValor + segundoValor;
        }

        public static int Restar(int primerValor, int segundoValor)
        {
            return primerValor - segundoValor;
        }

        public static int Multiplicar(int primerValor, int segundoValor)
        {
            return primerValor * segundoValor;
        }

        public static int Dividir(int primerValor, int segundoValor)
        {
            return primerValor / segundoValor;
        }


    }
}
