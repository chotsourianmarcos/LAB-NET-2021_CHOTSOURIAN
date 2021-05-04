using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Exceptions_Extensions
{
    public static class Logic
    {

        public static int numDivididoCero(this int n)
        {
            int a = 0;
            return n / a;
        }

        public static int divisionDosNumeros(this int numerador, int divisor)
        {
            return numerador / divisor;
        }

        public static double numANegativoYRaizCuadrada(this double num)
        {
            if (num == 0)
            {
                throw new CustomException();
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public static string arrojarCustomException(this string ejemplo)
        {
            throw new CustomException();
        }
    }
}
