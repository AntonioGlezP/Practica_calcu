using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_6B.Libreria
{

    /// <summary>
    /// metodo publico que envia un saludo
    /// </summary>
   public class Metodos
    {
       public string saludar()
       {
           return "Hola mundo";
       }
       /// <summary>
       /// Funcion que realiza la suma de dos numeros 
       /// </summary>
       /// <param name="valor1">flotante</param>
       /// <param name="valor2">flotante</param>
       /// <returns>resultado flotante</returns>
       public float sumar(float valor1, float valor2)
       {
           var resultado = valor1 + valor2;
           return resultado;

       }
       public float restar(float valor1, float valor2)
       {
           var resultado = valor1 - valor2;
           return resultado;

       }
       public float multiplicar(float valor1, float valor2)
       {
           var resultado = valor1 * valor2;
           return resultado;

       }
       public float dividir(float valor1, float valor2)
       {
           var resultado = valor1 / valor2;
           return resultado;

       }
    }
}
