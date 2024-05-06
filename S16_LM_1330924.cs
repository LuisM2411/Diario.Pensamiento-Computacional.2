using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S16___LM_1330924
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicio
            string[] alum = new string[5];
            alum[0] = "Juan";
            alum[1] = "Pedro";
            alum[2] = "Luisa";
            alum[3] = "Adriana";
            alum[4] = "Sofia";

            int[] nota = new int[5];
            nota[0] = (88);
            nota[1] = (75);
            nota[2] = (96);
            nota[3] = (77);
            nota[4] = (59);

            int prom = 0;
            int suma = 0;

            for (int i = 0; i<5; i++)
            {
                suma = suma + nota[i];
            }
            prom = suma / 5;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("" + alum[i] + "-" + nota[i] + ".");
            }
            Console.WriteLine("");
            Console.WriteLine("El promedio es: " + prom);
            //Final
            Console.ReadKey();

        }
    }
}
