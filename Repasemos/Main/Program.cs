using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repasemos.test;
using System.Threading.Tasks;


namespace Repasemos.Main
{
    class Program 
    {
    

      

        static void Main(string[] args)
        {
            Tienda t = new Tienda();
           
           
            short n=0;
            do
            {
                Mostrarmenu();
                OpcionMenu(ref n);
                switch (n)
                {
                    case 1:
                        t.añadir();
                        break;
                    case 2:
                        t.reparar();
                        break;
                }

            } while (n != 4);
        }



        static public void Mostrarmenu()
        {
            // Declaracion de variables
            int i;
            String[] Menu = { "Añadir", "Reparar",
                "Entregar","Salir"};
            //Proceso
            Console.Clear();
            for (i = 0; i < Menu.Length; i++)
            {
                Console.WriteLine("{0} - {1}", (i + 1), Menu[i]);

            }
            
        }//Nos mostrara el menu
        static public void OpcionMenu(ref short n)
        {
            // Declaracion de variables
            String x = "";
            Boolean escorrecto = false;
            //Proceso
            do
            {
                Console.WriteLine("¿Que deseas hacer?");
                x = Console.ReadLine();
                escorrecto = short.TryParse(x, out n);
                if (!escorrecto)
                {
                    Console.WriteLine("No has introducido un numero");
                    escorrecto = false;

                }
                else if (n < 1 || n > 4)
                {

                    Console.WriteLine("Por favor, ciñese al menu");
                    escorrecto = false;
                }
                else
                {
                    escorrecto = true;
                }



            } while (!escorrecto);
        }
    }

      
   }

