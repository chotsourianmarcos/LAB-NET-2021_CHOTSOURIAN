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
            int opcion = 99;
            while (opcion != 0)
            {
                Console.WriteLine("Escriba 1, 2, 3 o 4 para ejecutar cada ejercicio. 0 para terminar.");
                opcion = Convert.ToInt16(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Punto 1: ");
                        Console.WriteLine("Ingrese un número para intentar dividirlo por cero:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            Console.WriteLine(n.numDivididoCero());
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            Console.WriteLine("Se ha intentado vanamente dividir por cero\n");
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n\nPunto 2: ");
                        Console.WriteLine("Ingrese un int numerador y luego un int denominador para efectuar una division.");
                        try
                        {
                            int numerador = Convert.ToInt32(Console.ReadLine());
                            int denominador = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("El resultado es: " + numerador.divisionDosNumeros(denominador));
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine("Lo siento, dividir por cero es un tanto imposible de lograr.");
                            Console.WriteLine(ex.Message);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("No ha ingresado valores correctos.");
                        }
                        finally
                        {
                            Console.WriteLine("Se ha intentado con o sin exito realizar una division.\n");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\n\nPunto 3: ");
                        Console.WriteLine("Ingrese un numero para pasarlo a negativo y calcular su raiz cuadrada.\n" +
                                          "Si ingresa 0 será tenido en cuenta como un error de validacion.");
                        try
                        {
                            double num = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(num.numANegativoYRaizCuadrada());
                        }
                        catch (CustomException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message + "\n" + ex.GetType() + "\n");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\n\nPunto 4: ");
                        Console.WriteLine("Se arroja y captura una excepcion personalizada.");
                        try
                        {
                            "ejemplo".arrojarCustomException();
                        }
                        catch (CustomException ex)
                        {
                            Console.WriteLine(ex.Message + "\n" + ex.GetType());
                        }
                        finally
                        {
                            Console.WriteLine("Se ha arrojado y capturado una excepcion personalizada.\n");
                        }
                        break;

                    case 0:
                        break;
                }
            }

            Console.WriteLine("Fin.");
            Console.ReadLine();
        }
    }
}
