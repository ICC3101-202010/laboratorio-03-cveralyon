using System;
namespace lab03
{
    public class Compra
    {
        private DateTime p_time;
        private int[] p_list;
        private int id_cliente;
        private int n_boleta;
        private int id_empleado;
        private bool aux3;

        public DateTime P_time { get => p_time; set => p_time = value; }
        public int[] P_list { get => p_list; set => p_list = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int N_boleta { get => n_boleta; set => n_boleta = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public bool Aux3 { get => aux3; set => aux3 = value; }

        public Compra(DateTime p_time, int[] p_list, int id_cliente, int n_boleta, int id_empleado, bool aux3)
        {
            this.p_time = p_time;
            this.p_list = p_list;
            this.id_cliente = id_cliente;
            this.n_boleta = n_boleta;
            this.id_empleado = id_empleado;
            this.aux3 = aux3;
        }

       

        public void Hora_compra() { 

            string formats = "MM/dd/yyyy h:mm tt";
            string dateStrings = DateTime.Now.ToString();
            DateTime parsedDate; // duda con como funciona este comando
            DateTime.TryParseExact(dateStrings, formats, null,
                                        System.Globalization.DateTimeStyles.AllowWhiteSpaces |
                                        System.Globalization.DateTimeStyles.AdjustToUniversal,
                                        out parsedDate);
            p_time = parsedDate;          
        }

        public void Boleta(int i) // hacer un contador afuera que ingrese cada vez que se hace un a compra
        {



            N_boleta = 0 + i;
            Console.WriteLine("El Numero de su boleta es: {0} ", N_boleta);
        }

    }
}
