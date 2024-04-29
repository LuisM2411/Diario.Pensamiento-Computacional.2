using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParte2.LuisMAnthonyA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicio del programa
            //Iniciamos declarando variables
            string nombre = "";
            int tipoV = -1;
            int carga = -1;
            int distancia = 0;
            bool modo = true;

            const int AUTO = 1;
            const int CAMION = 2;
            const int MOTO = 3;

            const int GastoRobot = 5;
            const int GastoCamion = 10;
            const int GastoAuto = 25;
            const int GastoMoto = 20;

            //Se inicia el programa pidiendo datos al usuario
            Console.WriteLine("************************");
            Console.WriteLine("*                      *");
            Console.WriteLine("*  SiMULADOR DE GASTO  *");
            Console.WriteLine("*     DE ENERGON       *");
            Console.WriteLine("*                      *");
            Console.WriteLine("************************");
            Console.WriteLine("||(Solo patra Autobots)|");
            Console.WriteLine("||(Abajo los decepticons)|");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el nombre del robot: ");
            nombre = Console.ReadLine();
            do
            {
                Console.Write("Ingrese el tipo de vehiculo del autobot (1. Auto. 2. Camion. 3. Moto): ");
                tipoV = Convert.ToInt32(Console.ReadLine());
            } while (tipoV < 1 || tipoV > 3);
            do
            {
                Console.Write("Ingrese el nivel de energon (0-100%): ");
                carga = Convert.ToInt32(Console.ReadLine());
            } while (carga < 0 || carga > 100);
            Console.Write("Ingrese la posicion inicial del robot(Km de la base): ");
            distancia = Convert.ToInt32(Console.ReadLine());

            //se muestra el menu inical
            int opcion;
            while (true)
            {
                Console.WriteLine("|----------------------|");
                Console.WriteLine("|                      |");
                Console.WriteLine("|   Menu de opciones   |");
                Console.WriteLine("|                      |");
                Console.WriteLine("|----------------------|");
                Console.WriteLine("1. Imprimir informacion del robot");
                Console.WriteLine("2. Cargar energon");
                Console.WriteLine("3. Transformar");
                Console.WriteLine("4. Moverse");
                Console.WriteLine("5. Volver al menu inicial");
                Console.WriteLine("6. Terminar con el simulador");
                Console.Write("Ingrese una opcion: ");
                Console.Write("Ingrese una opcion: ");

                //inician las condiciones para cada opcion
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {   //Se incia con lo que hace la opcion 1
                    case 1:
                        Console.WriteLine("Nombre del autobot: " + nombre);
                        Console.WriteLine("Tipo de vehiculo: " + (tipoV == 1 ? "Auto" : (tipoV == 2 ? "Camion" : "Moto")));
                        Console.WriteLine("Nivel de energon: " + carga + "%");
                        Console.WriteLine("Posicon del autobot: " + distancia + "Km de la base");
                        Console.WriteLine("Modo: " + (modo ? "Robot" : "Vehiculo"));
                        Console.ReadKey(); //Esto limpia la pantalla y asi no se acumulan los procesos
                        break;
                    case 2: //La opcion 2 que carga el tanque de los poderosos autobots
                        if (carga < 100)
                        {
                            carga += 5;
                            if (carga > 100)
                            {
                                carga = 100;
                            }
                            Console.WriteLine("Energon recargado. Nivel actual de energon: " + carga + "%");
                        }
                        else
                        {
                            Console.WriteLine("Capacidad maxima de energon alcanzada");
                        }
                        Console.ReadKey();
                        break;
                    case 3: //en este se transforma el robot
                        modo = !modo;
                        if (modo)
                        {
                            Console.WriteLine("El autobot se transformo a modo robot.");
                        }
                        else
                        {
                            Console.WriteLine("El autobot se ha transformado a modo vehiculo.");
                        }
                        Console.ReadKey();
                        break;
                    case 4: //Opcion en la que se mueve el autobot. Que cosa mas extensa
                        Console.Write("Ingrese la cantidad de horas que se movera el robot: ");
                        int mov = Convert.ToInt32(Console.ReadLine());

                        int gasto = modo ? GastoRobot : (tipoV == AUTO ? GastoAuto : (tipoV == CAMION ? GastoCamion : GastoMoto));
                        int energianecesaria = mov * gasto;

                        if (carga < energianecesaria)
                        {
                            Console.WriteLine("Error: el nivel actual de energon no es suficiente para moverse por: " + mov + "horas");
                            Console.ReadKey();
                            break;
                        }
                        for (int i = 1; i <= mov; ++i)//Esto nos servira para la nueva posicion y el gasto hecho
                        {
                            int nuevapos = distancia + (modo ? 50 : (tipoV == AUTO ? 110 : (tipoV == CAMION ? 85 : 120)));

                            //Y ahora se mueve 
                            distancia = nuevapos;
                            carga -= gasto;
                            //Y ahora se actulizan datos
                            Console.WriteLine("Hora" + i + ": Posicion de la base:" + distancia + "Km. Nivel de energon: " + carga + "%");
                        }
                        Console.ReadKey();
                        break;
                    case 5: //Este nos regresara al menu inicial, donde se ingresan nuevos datos
                        Console.WriteLine("************************");
                        Console.WriteLine("*                      *");
                        Console.WriteLine("*  SiMULADOR DE GASTO  *");
                        Console.WriteLine("*     DE ENERGON       *");
                        Console.WriteLine("*                      *");
                        Console.WriteLine("************************");
                        Console.WriteLine("||(Solo patra Autobots)|");
                        Console.WriteLine("||(Abajo los decepticons)|");
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese el nombre del robot: ");
                        nombre = Console.ReadLine();
                        do
                        {
                            Console.Write("Ingrese el tipo de vehiculo del autobot (1. Auto. 2. Camion. 3. Moto): ");
                            tipoV = Convert.ToInt32(Console.ReadLine());
                        } while (tipoV < 1 || tipoV > 3);
                        do
                        {
                            Console.Write("Ingrese el nivel de energon (0-100%): ");
                            carga = Convert.ToInt32(Console.ReadLine());
                        } while (carga < 0 || carga > 100);
                        Console.Write("Ingrese la posicion inicial del robot(Km de la base): ");
                        distancia = Convert.ToInt32(Console.ReadLine());
                        Console.ReadKey();
                        break;
                    case 6:

                        return;
                    default:
                        Console.WriteLine("Opncion no valida. Ingrese una opcion que se presenta en el menu.");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();


            }

        }
    }
}

           