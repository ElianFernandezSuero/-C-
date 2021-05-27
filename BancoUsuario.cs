using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de Cuenta:");
            string NumeroCuenta = Console.ReadLine();
            Console.WriteLine("Nombre de usuario:");
            string Usuario = Console.ReadLine();
            Console.WriteLine("Saldo del Usuario:");
            decimal Saldo = decimal.Parse(Console.ReadLine()); 
            
            //Crear un objeto
            CuentaBancaria cuenta = new CuentaBancaria(NumeroCuenta, Usuario, Saldo);
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Salario: {2}", cuenta.NoCuenta, cuenta.Usuario, cuenta.Saldo);
        }
    }
}
