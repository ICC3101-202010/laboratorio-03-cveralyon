﻿using System;
using System.Collections.Generic;

namespace lab03
{
    public class Compra
    {
        private List<Producto> lista_prod = new List<Producto>();
        private DateTime p_time;
        private int id_cliente;
        private int n_boleta;
        private int id_empleado;
        private bool aux3;

        public List<Producto> Lista_prod { get => lista_prod; set => lista_prod = value; }
        public DateTime P_time { get => p_time; set => p_time = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int N_boleta { get => n_boleta; set => n_boleta = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public bool Aux3 { get => aux3; set => aux3 = value; }

        public Compra(List<Producto> lista_prod, DateTime p_time, int id_cliente, int n_boleta, int id_empleado, bool aux3)
        {
            this.lista_prod = lista_prod;
            this.p_time = p_time;
            this.id_cliente = id_cliente;
            this.n_boleta = n_boleta;
            this.id_empleado = id_empleado;
            this.aux3 = aux3;
        }

        public void Hora_compra()
        { 

            string formats = "MM/dd/yyyy h:mm tt";
            string dateStrings = DateTime.Now.ToString();
            DateTime parsedDate; // duda con como funciona este comando
            DateTime.TryParseExact(dateStrings, formats, null,
                                        System.Globalization.DateTimeStyles.AllowWhiteSpaces |
                                        System.Globalization.DateTimeStyles.AdjustToUniversal,
                                        out parsedDate);
            p_time = parsedDate;          
        }

        public void Agregar_producto( Producto producto, int cantidad )
        {                       
            if (producto.Stock >= cantidad)
            {
                for (int i = 0; ; i++)
                {
                    while (cantidad >= 0)
                    { 
                        lista_prod[0] = producto;
                        producto.Stock -= cantidad;
                        cantidad -= 1;
                    }
                    Console.WriteLine("Producto Agregado a la compra");

                }
            }
            else if (producto.Stock == 0)
            {
                Console.WriteLine("---LO SENTIMOS, PERO NO CONTAMOS CON EL STOCK SOLICITADO DE {0} ---", producto.Name);
            
            }
            else
            {
                Console.WriteLine("---LO SENTIMOS, PERO QUEDAN SOLO {0} UNIDADES DE {1} ---" +
                    "---INTENTE CON UNA CANTIDAD INFERIOR A LA SOLICITADA ---", producto.Stock , producto.Name);
            }
            

        }


        public void Boleta(int i, Empleado empleado, Cliente cliente, Compra compra)  // hacer un contador afuera que ingrese cada vez que se hace un a compra
        {
            N_boleta = 0 + i;
            id_cliente = cliente.Id;
            id_empleado = empleado.Id;
            cliente.Registro(compra);
            Console.WriteLine("\t\t---BOLETA---\n" +
                "\t\t\t\t Numero: # {0} \n" +
                "\t  Fecha y Hora: {2}", N_boleta, compra.p_time);
            Console.WriteLine("");
            Console.WriteLine("Cliente: {0} {1} \n" +
                "Rut: {2}", cliente.Name, cliente.Last, cliente.Id);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Cajero: {0} {1} \n" +
                "Rut: {2}", empleado.Name, empleado.Last, empleado.Id);

            Console.WriteLine("\t\t-----LISTA DE COMPRA-----");
            Console.WriteLine("\n\n");
            Console.WriteLine("    CODIGO      PRODUCTO           PRECIO     ");
           
            foreach (Producto prod in lista_prod)
            {
                Console.WriteLine("-> {0} -- {1} -- $ {2} ", prod.Code, prod.Name, prod.Price);
            }

            

           
        }

    }
}
