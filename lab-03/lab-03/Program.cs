using System;
using System.Collections.Generic;

namespace lab03
{
    class MainClass : Funciones
    {
        public static void Main(string[] args)
        {
            Funciones funciones = new Funciones();
            int count_emp = 0;
            int count_cli = 0;

            Console.WriteLine("\n\n\t\t------Bienvenido al Portal Virtual de LAIDER CHILE------\n\n");
            Console.WriteLine(" \tSeleccione el MODO de Inicio del Programa:\n" +
                "==> 1 -- Ingresar de manera manual\n" +
                "==> 2 -- Simulacion Automatica\n" +
                "==> 3 -- Cerrar Programa");

            int modo = funciones.Numero(3);

            switch (modo)
            {
                case 1:                         // opciones de que tipo de persona es la que usara el programa 
                    int plataforma;
                    do
                    {
                        Console.WriteLine("  ------------------------------------------------------------------  ");
                        Console.WriteLine("  ------------------------------------------------------------------  ");
                        Console.WriteLine("Seleccione la Plataforma deseada:\n" +
                         "\t\t1 --> Empleados \n" +
                         "\t\t2 --> Clientes \n" +
                         "\t\t3 --> Cerrar Programa \n");

                        plataforma = funciones.Numero(3);

                        switch (plataforma)
                        {
                            case 1:     // EMPLEADOS
                                int op_empleado;
                                do
                                {
                                    Console.WriteLine("  ------------------------------------------------------------------  ");
                                    Console.WriteLine("  ------------------------------------------------------------------  ");
                                    Console.WriteLine("Seleccione la opcion deseada:\n" +
                                     "\t\t1 --> Ingresar Datos de un nuevo empleado\n" +
                                     "\t\t2 --> Mostrar los datos de TODOS los Empleados LAIDER CHILE \n" +
                                     "\t\t3 --> Cambiar el Cargo de un Empleado\n" +
                                     "\t\t4 --> Cambiar el Sueldo de un Empleado\n" +
                                     "\t\t5 --> Cambiar el Horario de un Empleado\n" +
                                     "\t\t6 --> Agregar un Producto\n" +
                                     "\t\t7 --> Editar Producto\n" +
                                     "\t\t8 --> Volver al Menu Anterior\n");
                                    op_empleado = funciones.Numero(8);
                                    funciones.Editar_empleado(op_empleado, count_emp);
                                    if (op_empleado == 1) { count_emp += 1; }
                                } while (op_empleado != 8);
                                break;
                            case 2:             // CLIENTES
                                int op_cliente;
                                do
                                {
                                    Console.WriteLine("  ------------------------------------------------------------------  ");
                                    Console.WriteLine("  ------------------------------------------------------------------  ");
                                    Console.WriteLine("Seleccione la opcion deseada:\n" +
                                     "\t\t1 --> Ingresar Datos de un nuevo Cliente\n" +
                                     "\t\t2 --> Mostrar los datos de TODOS los Clientes\n" +
                                     "\t\t3 --> Ver lista de Productos\n" +
                                     "\t\t4 --> Hacer una Compra\n" +
                                     "\t\t5 --> Mostra Historial de Compras de Cliente\n" +
                                     "\t\t6 --> Volver al Menu Anterior\n");
                                    op_cliente = funciones.Numero(6);
                                    funciones.Editar_cliente(op_cliente, count_cli);
                                    if (op_cliente == 1) { count_emp += 1; }
                                } while (op_cliente != 6);
                                break;
                            case 3:         //CLOSE PROGRAME
                                break;

                            default:
                                Console.WriteLine("\n-------ERROR: Opcion no valida--Ingrese una opcion valida--------\n");
                                break;


                        }
                    } while (plataforma != 3);



                    break;
                case 2:
                    Console.WriteLine("  ------------------------------------------------------------------  ");
                    Console.WriteLine("  ------------------------------------------------------------------  ");
                    Console.WriteLine("Esta opcion aun esta en construccion, lamentamos las molestias");
                    Console.WriteLine("  ------------------------------------------------------------------  ");
                    Console.WriteLine("  ------------------------------------------------------------------  ");
                    break;
                case 3:
                    break;
            }
        }       
    }
}        

            
           
