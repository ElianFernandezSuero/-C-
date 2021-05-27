using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace putoElian
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = Console.ReadLine();
            int dato2 = int.Parse(dato);

            if (dato2 >= 0  && dato2 <= 10)
            {
                for (int i = 1; i<=10 ; i++)
                {
                    int resultado = dato2 * i; 
                    Console.WriteLine("{0} x {1} = {2}", dato2, i, resultado);
                }
            }
            else
            {
                Console.WriteLine("Weno manitooooo, usted se la acaba de beberrrrrrrrrrrrrrr");
            }
        }

    }
}
