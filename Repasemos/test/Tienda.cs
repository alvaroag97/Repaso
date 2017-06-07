using Repasemos.Enumeraciones;
using Repasemos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repasemos.test
{
    class Tienda
    {
        private List<Dispositivo> Lista = new List<Dispositivo>();


        public void añadir()
        {
            String Marca, Modelo, pulgadas;
            SO sO;
            String SO, FuenteAlimentacion, Procesador;
            RAM ram;
            String x;
            int s;
            Boolean escorrecto;
            short n;
            
            do
            {
                Console.WriteLine("1-Movil");
                Console.WriteLine("2-Tablet");
                Console.WriteLine("3-Pc");
                Console.WriteLine("4-Portatil");
                Console.WriteLine("Que deseas añadir");
                x = Console.ReadLine();
                escorrecto = short.TryParse(x, out n);
                if (!escorrecto)
                {
                    Console.WriteLine("No has introducido un numero");
                    escorrecto = false;

                }
                else if (n < 1 || n > 3)
                {

                    Console.WriteLine("Por favor, ciñese al menu");
                    escorrecto = false;
                }
                else
                {
                    escorrecto = true;
                }



            } while (!escorrecto);

            switch (n)
            {
                case 1:
                    //movil : string marca, string modelo, string pulgadas, SO sO
                    Console.WriteLine("Introduzca marca");
                    Marca = Console.ReadLine();
                    Console.WriteLine("Introduzca modelo");
                    Modelo = Console.ReadLine();
                    Console.WriteLine("Introduzca pulgadas");
                    pulgadas = Console.ReadLine();
                    Console.WriteLine("Introduzca sistema operativo");
                    Console.WriteLine("1-Android");
                    Console.WriteLine("2-iOS");
                    s = Console.Read();
                    sO = (SO)s;

                    Lista.Add(new Movil(Marca, Modelo, pulgadas, sO));
                    break;
                case 2:
                    //Tablet : string marca, string modelo, string pulgadas, SO sO
                    Console.WriteLine("Introduzca marca");
                    Marca = Console.ReadLine();
                    Console.WriteLine("Introduzca modelo");
                    Modelo = Console.ReadLine();
                    Console.WriteLine("Introduzca pulgadas");
                    pulgadas = Console.ReadLine();
                    Console.WriteLine("Introduzca sistema operativo");
                    Console.WriteLine("1-Android");
                    Console.WriteLine("2-iOS");
                    s = Console.Read();
                    sO = (SO)s;

                    Lista.Add(new Tablet(Marca, Modelo, pulgadas, sO));

                    break;
                case 3:
                    
                    Console.WriteLine("Introduzca marca");
                    Marca = Console.ReadLine();
                    Console.WriteLine("Introduzca modelo");
                    Modelo = Console.ReadLine();
                    Console.WriteLine("Introduzca pulgadas");
                    pulgadas = Console.ReadLine();
                    Console.WriteLine("Introduzca Sistema operativo");
                    String so = Console.ReadLine();
                    Console.WriteLine("Introduzca fuente de alimentacion");
                    FuenteAlimentacion = Console.ReadLine();
                    Console.WriteLine("Introduzca ram");
                    Console.WriteLine("1- 1GB");
                    Console.WriteLine("2- 2GB");
                    Console.WriteLine("3- 4GB");
                    Console.WriteLine("4- 8GB");
                    Console.WriteLine("5- 16GB");
                    Console.WriteLine("6- 32GB");
                    s = Console.Read();
                    ram = (RAM)s;
                    Console.WriteLine("Introduzca procesador");
                    Procesador = Console.ReadLine();
                    //PC : string marca, string modelo, string pulgadas, string sO, string fuentealimentacion, RAM ram, string procesador
                    Lista.Add(new Pc(Marca, Modelo, pulgadas, so, FuenteAlimentacion, ram, Procesador));
                    break;
                case 4:
                    Console.WriteLine("Introduzca marca");
                    Marca = Console.ReadLine();
                    Console.WriteLine("Introduzca modelo");
                    Modelo = Console.ReadLine();
                    Console.WriteLine("Introduzca pulgadas");
                    pulgadas = Console.ReadLine();
                    Console.WriteLine("Introduzca Sistema operativo");
                    String sos = Console.ReadLine();
                    Console.WriteLine("Introduzca ram");
                    Console.WriteLine("1- 1GB");
                    Console.WriteLine("2- 2GB");
                    Console.WriteLine("3- 4GB");
                    Console.WriteLine("4- 8GB");
                    Console.WriteLine("5- 16GB");
                    Console.WriteLine("6- 32GB");
                    s = Console.Read();
                    ram = (RAM)s;
                    Console.WriteLine("Introduzca procesador");
                    Procesador = Console.ReadLine();
                    //Portatil : string marca, string modelo, string pulgadas, string sO, RAM ram, string procesador
                    Lista.Add(new Portatil(Marca, Modelo, pulgadas, sos, ram, Procesador));
                    break;
            }

            
        }
        public void reparar()
        {
            foreach (Dispositivo a in Lista)
            {
                Console.WriteLine(a.ToString());
                
            }
            Console.ReadLine();
        }
        public void entregar()
        {

        }
    }
}
