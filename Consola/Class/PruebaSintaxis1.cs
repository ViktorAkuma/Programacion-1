using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola.Class
{
    public class PruebaSintaxis1
    {
        //metodo que se llama igual que la clase y no tiene tipo de retorno
        //es constructor de la clase 
        //se ejecuta cuando se crea un objeto de la clase
        private static int saldoFactura;
        private static string cliente;
        public PruebaSintaxis1()
        
               //declaracion de campos o propiedades
    
       
        {

            saldoFactura = 10005;
            cliente = "Juan Perez";

            int numero = 10;
            string nombre = "Juan";
            double precio = 19.99;
            bool esVerdadero = true;

        }

        public void imprimirSaludo(string v)
        {
            Console.WriteLine($"Hola, {v}!");
        }


        public void imprimirDeudaFactura()
        {
            double saldoFactura = 10005;
            string cliente = "Juan Perez";
            Console.WriteLine($"Cliente: {cliente}, Saldo de la factura: {saldoFactura}");
        }

    }
}

