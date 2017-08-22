using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora_6B.Libreria;

namespace Calculadora_6B.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos misMetodos = new Metodos();
            Console.WriteLine(misMetodos.saludar());
            Console.ReadKey();
        }
    }
}
