using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola.Class
{
    public class PruebaSintaxis1
    {
        //declaración de campos o propiedades
        private double saldoFactura;
        private string cliente;

        //metodo que se llama igual que la clase y que no tiene tipo de retorno
        //es el constructor de la clase
        //se ejecuta cuando se crea un objeto de la clase
        public PruebaSintaxis1()
        {
            saldoFactura = 1000.50;
            cliente = "Juan Pérez";
            int numero = 10;
            string nombre = "Juan";
            double precio = 19.99;
            bool esVerdadero = true;
            //Declaramos una variable de tipo var
            var edad = 25;
            var apellido = "Pérez";
            var casado = false;


        }
        public void ImprimirDeudaFactura()
        {
            Console.WriteLine(cliente + " tiene una deuda de " + saldoFactura);
        }

        public void ImprimirSaludo(string nom)
        {
            Console.WriteLine("Hola " + nom);
        }
    }
}
