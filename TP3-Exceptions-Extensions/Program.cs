using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Exceptions_Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Punto 1: ");
            Console.WriteLine("Se intenta dividir 10 / 0 .");
            try
            {
                int a = 10;
                int b = 0;
                int divporcero = a/b;
            }catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Se ha intentado vanamente dividir por cero");
            }



            Console.WriteLine("\n\nPunto 2: ");
            Console.WriteLine("Ingrese un int numerador y luego un int denominador para efectuar una division.");
            bool hayNumerador = false;
            bool hayDenominador = false;
            int numerador = 0;
            int denominador = 0;
            while(hayNumerador == false)
            {
                try
                {

                    numerador = Convert.ToInt32(Console.ReadLine());
                    hayNumerador = true;
                }catch(Exception)
                {
                    Console.WriteLine("Ingrese un int por favor.");
                }
            }
            while (hayDenominador == false)
            {
                try
                {

                    denominador = Convert.ToInt32(Console.ReadLine());
                    hayDenominador = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ingrese un int por favor.");
                }
            }
            try
            {

                int resultadoDivision = numerador / denominador;
                Console.WriteLine("El resultado es " + resultadoDivision);
            }catch (DivideByZeroException ex)
            {
                Console.WriteLine("Dividir por cero genera paradojas insostenibles. Desista por favor.");
                Console.WriteLine(ex.Message);
            }



            Console.WriteLine("\n\nPunto 3: ");
            Console.WriteLine("Ingrese un numero para elevarlo al cuadrado. Si ingresa vacio dara error.");
            try
            {

                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num.numCuadrado());
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }



            Console.WriteLine("\n\nPunto 4: ");
            Console.WriteLine("Ingrese un numero para elevarlo al cuadrado. Si ingresa vacio dara error.");
            try
            {

                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num.numCuadrado());
            }
            catch (Exception)
            {
                try
                {
                    throw new CustomException();
                }
                catch (CustomException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            Console.WriteLine("Fin.");
            Console.ReadLine();
        }
    }
}
