using System;
namespace lab03
{
    public class Cliente : Persona
    {
        private string[] lista;
        private bool aux2;
        private int paga;
        private int horas;
        private int horario;

        public Cliente(int id, string name, string last, DateTime birth, string nacion) : base(id, name, last, birth, nacion)
        {
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




    }
}
