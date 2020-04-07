using System;
using System.Collections.Generic;

namespace lab03
{
    public class Empleado : Persona
    {
        private string cargo;
        private bool aux;
        private int paga;
        private int horas;
        private int horario;

        public string Cargo { get => cargo; set => cargo = value; }
        public bool Aux { get => aux; set => aux = value; }
        public int Paga { get => paga; set => paga = value; }
        public int Horas { get => horas; set => horas = value; }
        public int Horario1 { get => horario; set => horario = value; }

        public Empleado(int id, string name, string last, DateTime birth, string nacion) : base(id, name, last, birth, nacion)
        {
            this.Id = id;
            this.Name = name;
            this.Last = last;
            this.Birth  = birth;
            this.Nacion = nacion;
            
        }

        

        public void Show_Datos()
        {
            Console.WriteLine("  ------------------------------------------------------------------  ");
            Console.WriteLine("Ficha Personal de {0} {1}: \n", Name, Last);
            Console.WriteLine("Id: {0}: \n", Id);
            Console.WriteLine("Fecha de Nacimiento: {0}: \n", Birth);
            Console.WriteLine("Nacionalidad: {0}: \n", Nacion);
            Console.WriteLine("Cargo: {0}: \n", cargo);
            Console.WriteLine("Sueldo: {0}: \n", paga);
            Console.WriteLine("Horario de trabajo: {0} ({1} Horas Diarias\n", horario, horas);
            Console.WriteLine("  ------------------------------------------------------------------  ");


        }


        public void Puesto()
        {
            int c;
            while (aux)
            {
                Console.WriteLine("Seleccione el cargo que desea asignar al empleado: \n" +
                    "\t\t1 --> Jefe de Local\n" +
                    "\t\t2 --> Supervisor de Cajas\n" +
                    "\t\t3 --> Cajero\n" +
                    "\t\t4 --> Reponedor\n" +
                    "\t\t5 --> Auxiliar de Limpieza\n" +
                    "\t\t6 --> Guardia de Seguridad\n" +
                    "\t\t7 --> Encargado de Bodega\n");
                c = int.Parse(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        cargo = "Jefe de Local";
                        aux = false;
                        break;
                    case 2:
                        cargo = "Supervisor de Cajas";
                        aux = false;
                        break;
                    case 3:
                        cargo = "Cajero";
                        aux = false;
                        break;
                    case 4:
                        cargo = "Reponedor";
                        aux = false;
                        break;
                    case 5:
                        cargo = "Auxiliar de Limpieza";
                        aux = false;
                        break;
                    case 6:
                        cargo = "Guardia de Seguridad";
                        aux = false;
                        break;
                    case 7:
                        cargo = "Encargado de Bodega";
                        aux = false;
                        break;
                    default:
                        Console.WriteLine("\n-------ERROR: Opcion no valida--Ingrese una opcion valida--------");
                        break;
                }
            }
        }

        public void Sueldo()
        {
            aux = true;
            while (aux)
            {
                Console.WriteLine("Ingrese el sueldo que recibira el empleado(numero, sin puntos ni comas): \n");
                paga = int.Parse(Console.ReadLine());
                if (paga < 319000)
                {
                    Console.WriteLine("El sueldo de su empleado debe ser superior a 319.000, dado que es el sueldo minimo en chile");
                }
                else if (paga >= 319000)
                {
                    Console.WriteLine("El monto fue guardado con exito");
                    aux = false;
                }
                else
                {
                    Console.WriteLine("\n-------ERROR: Opcion no valida--Ingrese una opcion valida--------");
                }
            }
        }

        public void Horario()
        {
            aux = true;
            while (aux)
            {
                Console.WriteLine("Ingrese la cantidad de horas con las que debera cumplir el empleado:\n" +
                    "\t\t --> 4 Horas diarias\n" +
                    "\t\t --> 6 Horas diarias\n" +
                    "\t\t --> 8 Horas diarias\n" +
                    "\t\t --> 10 Horas diarias\n");
                horas = int.Parse(Console.ReadLine());
                if (horas == 4 || horas == 6 || horas == 8 || horas == 10)
                {
                    aux = false;
                }               
                else
                {
                    Console.WriteLine("\n-------ERROR: Opcion no valida--Ingrese una opcion valida--------\n" +
                        "4 / 6 / 8 / 10");
                }
                int h;
                switch (horas)
                {
                    case 4:
                        Console.WriteLine("Cual sera el horario:\n" +
                    "\t\t 1--> 09:00 - 13:00\n" +
                    "\t\t 2--> 14:00 - 18:00\n");
                        h = int.Parse(Console.ReadLine());
                        if (h == 1 || h == 2)
                        {
                            Console.WriteLine("El horario fue guardado con exito");
                            aux = false;
                        }
                        else
                        {
                            Console.WriteLine("\n-------ERROR: Opcion no valida--Ingrese una opcion valida--------\n" +
                        "1 / 2 ");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Cual sera el horario:\n" +
                    "\t\t 1--> 08:00 - 14:00\n" +
                    "\t\t 2--> 14:00 - 20:00\n");
                        h = int.Parse(Console.ReadLine());
                        if (h == 1 || h == 2)
                        {
                            Console.WriteLine("El horario fue guardado con exito");
                            aux = false;
                        }
                        else
                        {
                            Console.WriteLine("\n-------ERROR: Opcion no valida--Ingrese una opcion valida--------\n" +
                        "1 / 2 ");
                        }
                        break;
                    case 8:
                        Console.WriteLine("Cual sera el horario:\n" +
                    "\t\t 1--> 08:00 - 16:00\n" +
                    "\t\t 2--> 14:00 - 22:00\n");
                        h = int.Parse(Console.ReadLine());
                        if (h == 1 || h == 2)
                        {
                            Console.WriteLine("El horario fue guardado con exito");
                            aux = false;
                        }
                        else
                        {
                            Console.WriteLine("\n-------ERROR: Opcion no valida--Ingrese una opcion valida--------\n" +
                        "1 / 2 ");
                        }
                        break;
                    case 10:
                        Console.WriteLine("Cual sera el horario:\n" +
                    "\t\t 1--> 08:00 - 18:00\n" +
                    "\t\t 2--> 12:00 - 22:00\n");
                        h = int.Parse(Console.ReadLine());
                        if (h == 1 || h == 2)
                        {
                            Console.WriteLine("El horario fue guardado con exito");
                            aux = false;
                        }
                        else
                        {
                            Console.WriteLine("\n-------ERROR: Opcion no valida--Ingrese una opcion valida--------\n" +
                        "1 / 2 ");
                        }
                        break;
                    default:
                        break;


                }
            }

        }
    }
}
