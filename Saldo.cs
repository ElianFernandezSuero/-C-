using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Las_clases_privadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase_privada saldo = new Clase_privada();
            Console.WriteLine("Ingresa el saldo");
            decimal dato = decimal.Parse (Console.ReadLine());

            saldo.Saldo = dato;

            Console.WriteLine("Tu Saldo es: {0}", saldo.Saldo);
        }
    }
}
