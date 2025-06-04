using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola.Class
{
    public class PruebaSintaxis1
    {
            //declaracion de campos o propiedades
            private double saldoFactura;
            private string cliente;

        public PruebaSintaxis1()
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


