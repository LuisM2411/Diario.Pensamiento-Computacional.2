using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace S15_LM1330924
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long dni;
            string letraUSUA;
            Console.Write("Ingrese su numero de DNI: ");
            dni = Convert.ToInt64(Console.ReadLine());
            Console.Write("Ingrese la letra del DNI: ");
            letraUSUA = Console.ReadLine();
            string letraReal = calculaLetra(dni);
            if (letraUSUA == letraReal)
            {
                Console.Write("Biemvenido al sistema: ");
            }else
            {
                Console.Write("Informacion invalida. No puede entrar al sistema.");

            }
            Console.ReadKey();
        }
        public static string calculaLetra(long dni)
        {
            long residuo = dni % 21;
            String letra = "";

            if (residuo <= 0 && residuo >= 5)
            {
                letra = "A";
            }
            else if (residuo >= 6 && residuo <= 10)
            {
                letra = "B";
            }
            else if (residuo >= 11 && residuo <= 15)
            {
                letra = "C";
            }else if(residuo >=16 && residuo <= 20)
            {
                letra = "D";
            }
                 
   
            
                   
            
            Console.WriteLine("La letra correcta es: "+letra);
            return letra;
        }
       
    }
}