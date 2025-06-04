using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcu.Class
{
    public class Calculadora
    {
        //Declaración de campos o propiedades
        protected double resultado;
        protected string operacion;
        //método que se llama igual que la clase y que no tiene tipo de retorno
        //es el constructor de la clase
        //se ejecuta cuando se crea un objeto de la clase
        public static int instancias=0;

        public Calculadora()
        {
            instancias++;
            resultado = 0;
            operacion = "";
        }
        public void Sumar(double num1, double num2)
        {
            resultado = num1 + num2;
            operacion = "Suma";
        }
        public void Restar(double num1, double num2)
        {
            resultado = num1 - num2;
            operacion = "Resta";
        }
        public void Multiplicar(double num1, double num2)
        {
            resultado = num1 * num2;
            operacion = "Multiplicación";
        }
        public void Dividir(double num1, double num2)
        {
            if (num2 != 0)
            {
                resultado = num1 / num2;
                operacion = "División";
            }
            else
            {
                Console.WriteLine("Error: División por cero");
            }
        }
        public static void Potencia(double baseNum, double exponente)
        {
            var resultado = Math.Pow(baseNum, exponente);
            Console.WriteLine("El resultado de la potencia es: " + resultado);
        }

        public void ImprimirResultado()
        {
            Console.WriteLine("El resultado de la " + operacion + " es: " + resultado);
        }
    }
}

