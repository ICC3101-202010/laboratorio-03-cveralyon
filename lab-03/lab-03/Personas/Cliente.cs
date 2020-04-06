using System;
using System.Collections.Generic;

namespace lab03
{
    public class Cliente : Persona
    {
        private List<Compra> historial = new List<Compra>();


        public List<Compra> Historial { get => historial; set => historial = value; }

        public Cliente(int id, string name, string last, DateTime birth, string nacion, List<Compra> historial) : base(id, name, last, birth, nacion)
        {
            this.Id = id;
            this.Name = name;
            this.Last = last;
            this.Birth = birth;
            this.Nacion = nacion;
            this.historial = historial;

        }

        public void Datos_cl()
        {
            Console.WriteLine("Ingrese los datos personales del Cliente: \n");
            Console.WriteLine("\t Nombre: ");
            Name = Console.ReadLine();
            Console.WriteLine("Apellido: \n");
            Last = Console.ReadLine();
            Console.WriteLine("Id (Rut): \n");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Fecha de Nacimiento: \n");
            string formats = "yyyy/MM/dd";
            string dateStrings = Console.ReadLine();
            DateTime parsedDate; // duda con como funciona este comando
            if (DateTime.TryParseExact(dateStrings, formats, null,
                                        System.Globalization.DateTimeStyles.AllowWhiteSpaces |
                                        System.Globalization.DateTimeStyles.AdjustToUniversal,
                                        out parsedDate))
                Birth = parsedDate;
            Console.WriteLine("Nacionalidad: \n");
            Nacion = Console.ReadLine();
        }

        public void Registro(Compra compra)
        {
            historial.Add(compra);
        }

        public void Show_registro()
        {
            Console.WriteLine("Historial de Compras de {0} {1} ", Name, Last);
            foreach (Compra comp in historial)
            {
                
                Console.WriteLine("--> BOLETA  Nro. # {0}   Fecha y Hora: {1}", comp.N_boleta, comp.P_time);
                Console.WriteLine("Id Cajero: {0}", comp.Id_empleado);
                Console.WriteLine("");
                Console.WriteLine("    CODIGO      PRODUCTO           PRECIO     ");
                foreach (Producto prod in comp.Lista_prod)
                {
                    Console.WriteLine("-> {0} -- {1} -- $ {2} ", prod.Code, prod.Name, prod.Price);
                }


            }
        }
    }
}
