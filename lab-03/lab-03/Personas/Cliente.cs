using System;
using System.Collections.Generic;

namespace lab03
{
    public class Cliente : Persona
    {
        private List<Compra> historial = new List<Compra>();


        public List<Compra> Historial { get => historial; set => historial = value; }

        public Cliente(int id, string name, string last, DateTime birth, string nacion) : base(id, name, last, birth, nacion)
        {
            this.Id = id;
            this.Name = name;
            this.Last = last;
            this.Birth = birth;
            this.Nacion = nacion;

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
                    Console.WriteLine("->  {0}   --   {1}   --   $ {2} ", prod.Code, prod.Name, prod.Price);
                }


            }
        }

        public void Show_D()
        {
            Console.WriteLine("  ------------------------------------------------------------------  ");
            Console.WriteLine("Ficha Personal de {0} {1}: \n", Name, Last);
            Console.WriteLine("Id: {0}: \n", Id);
            Console.WriteLine("Fecha de Nacimiento: {0}: \n", Birth);
            Console.WriteLine("Nacionalidad: {0}: \n", Nacion);    
            Console.WriteLine("  ------------------------------------------------------------------  ");


        }
    }
}
