using Consola.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcu.Class
{
    public class CalculadoraCientifica: Calculadora
    {

        //potencia
        public void Potencia(double num1, double num2)
        {
            resultado = Math.Pow(num1, num2);
            operacion = "Potencia";
        }
        //raiz cuadrada
        public void RaizCuadrada(double num1)
        {
            if (num1 >= 0)
            {
                resultado = Math.Sqrt(num1);
                operacion = "Raiz Cuadrada";
            }
            else
            {
                Console.WriteLine("Error: Raiz cuadrada de un número negativo");
            }
        }
    }
}
