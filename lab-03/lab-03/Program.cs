using System;
using System.Collections.Generic;

namespace lab03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\n------Bienvenido al Portal Virtual de LAIDER CHILE------\n\n\n");           
            Console.WriteLine("Seleccione la Plataforma deseada:\n" + 
                 "\t\t1 --> Empleados \n" + 
                 "\t\t2 --> Clientes \n" +
                 "\t\t3 --> Cerrar Programa \n");
            bool aux0;
            int plataforma;
            do
            {
                string p;
                p = Console.ReadLine();
                aux0 = int.TryParse(p, out plataforma);
                if (aux0 == false) { Console.WriteLine("---ERROR: INGRESE SOLO NUMEROS---"); }
            } while (!aux0);

            switch (plataforma)
            {
                case 1:


                    break;
                case 2:



                    break;
                case 3:
                    break;

                default:
                    Console.WriteLine("\n-------ERROR: Opcion no valida--Ingrese una opcion valida--------");
                    break;


            }
            {

            }
            //Console.WriteLine("\t\t\t--MENU--\n");

            /* int cat;
            Console.WriteLine("A que categoria corresponde el producto que desea ingresar:\n" +
                "\t\t1-- > Bebestible\n" +
                "\t\t2 --> Carnes\n" +
                "\t\t3 --> Verduras\n" +
                "\t\t4 --> Congelados\n" +
                "\t\t5 --> Despensa\n" +
                "\t\t6 --> Panaderia y Pasteleria\n" +
                "\t\t7 --> Quesos y Fiambres\n\n");

            cat = int.Parse(Console.ReadLine());

            switch (cat)
            {
                case 1:
                    categorie = "Bebestible";// crear lista de listas para meter los productos en una loista diferente dado su categoria
                    aux1 = false;
                    break;
                case 2:
                    categorie = "Carnes";
                    aux1 = false;
                    break;
                case 3:
                    categorie = "Verduras";
                    aux1 = false;
                    break;
                case 4:
                    categorie = "Congelados";
                    aux1 = false;
                    break;
                case 5:
                    categorie = "Despensa";
                    aux1 = false;
                    break;
                case 6:
                    categorie = "Panaderia y Pasteleria";
                    aux1 = false;
                    break;
                case 7:
                    categorie = "Quesos y Fiambres";
                    aux1 = false;
                    break;
                default:
                    Console.WriteLine("\n-------ERROR: Opcion no valida--Ingrese una opcion valida--------");
                    break;
               }
               */
        }

            

        
    }
}
