using System;
using System.Collections.Generic;
namespace lab03
{
    public class Funciones
    {
        List<Empleado> empleados = new List<Empleado>();
        List<Producto> productos = new List<Producto>();
        List<Cliente> clientes = new List<Cliente>();


        public int Numero(int o) // verifica que el input  sea un numero dentro del rango requerido
        {
            int n;
            bool aux0 = true;
            do
            {
                string p;
                p = Console.ReadLine();
                aux0 = int.TryParse(p, out n);
                if (aux0 == false) { Console.WriteLine("---ERROR: INGRESE SOLO NUMEROS del 1 al {0}---", o); }
            } while (!aux0 & n <= 0);
            return n;
        }


        public void Editar_empleado(int p, int count) // muestra el menu para la opcion empleados
        {
            switch(p)
            {
                case 1:
                    Console.WriteLine("Ingrese los datos personales del Empleado: \n");
                    Console.WriteLine("\t Nombre: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Apellido: \n");
                    string last = Console.ReadLine();
                    Console.WriteLine("Id (Rut): \n");
                    int id = Numero(999999999);
                    Console.WriteLine("Fecha de Nacimiento: \n");
                    string formats = "yyyy/MM/dd";
                    string dateStrings = Console.ReadLine();
                    DateTime parsedDate; // duda con como funciona este comando
                    if (DateTime.TryParseExact(dateStrings, formats, null,
                                                System.Globalization.DateTimeStyles.AllowWhiteSpaces |
                                                System.Globalization.DateTimeStyles.AdjustToUniversal,
                                                out parsedDate))
                                           
                    Console.WriteLine("Nacionalidad: \n");
                    string nacion = Console.ReadLine();
                    empleados[count] = new Empleado(id, name, last, parsedDate, nacion);
                    empleados[count].Puesto();
                    empleados[count].Sueldo();
                    empleados[count].Horario();
                    break;
                case 2:
                    foreach (Empleado emp in empleados)
                    {
                        emp.Show_Datos();
                    }
                    break;

                case 3:
                    int l = 0;
                    foreach (Empleado emp in empleados)
                    {
                        Console.WriteLine("Nro. -     RUT   --        NOMBRE \n");
                        Console.WriteLine("{0}   - {1} --  {2}  {3} ",l,emp.Id, emp.Name, emp.Last );
                        l += 1;
                    }
                    Console.WriteLine("\nIngrese el Numero del Empleado que desea Modificar:");
                    int mod = Numero(l);
                    empleados[mod].Puesto();
                    break;

                case 4:
                    int k = 0;
                    foreach (Empleado emp in empleados)
                    {
                        Console.WriteLine("Nro. -     RUT   --        NOMBRE \n");
                        Console.WriteLine("{0}   - {1} --  {2}  {3} ", k, emp.Id, emp.Name, emp.Last);
                        k += 1;
                    }
                    Console.WriteLine("\nIngrese el Numero del Empleado que desea Modificar:");
                    int mod1 = Numero(k);
                    empleados[mod1].Sueldo();
                    break;

                case 5:
                    int j = 0;
                    foreach (Empleado emp in empleados)
                    {
                        Console.WriteLine("Nro. -     RUT   --        NOMBRE \n");
                        Console.WriteLine("{0}   - {1} --  {2}  {3} ", j, emp.Id, emp.Name, emp.Last);
                        j += 1;
                    }
                    Console.WriteLine("\nIngrese el Numero del Empleado que desea Modificar:");
                    int mod2 = Numero(j);
                    empleados[mod2].Horario();
                    break;

                case 6:
                    Console.WriteLine("\nIngrese el nombre del prodcuto:");
                    string p_name = Console.ReadLine();
                    Console.WriteLine("\nIngrese la Marca del Producto: ");
                    string brand = Console.ReadLine();
                    Console.WriteLine("\nIngrese el Precio de Venta del Producto ( Ingrese el valor sin numero ni coma) : ");
                    int price = Numero(999999999);
                    Console.WriteLine("\nIngrese el Stock inicial del Producto ( Ingrese el valor sin numero ni coma) : ");
                    int stock = Numero(99999);                   
                    int code = 999999 - count;
                    Console.WriteLine("El codigo generado para el producto ingresado es: {0} ", code);
                    productos.Add(new Producto(code, p_name, price, brand, stock));
                    break;

                case 7:
                    Console.WriteLine("\nIngrese el Codigo del prodcuto:");
                    int cod = Numero(9999);
                    foreach (Producto pro in productos)
                    {
                        if (pro.Code== cod)
                        {
                            Console.WriteLine("Que desea editar:\n" +
                                "1 >> Precio\n" +
                                "2 >> Stock\n");
                            int ed = Numero(2);
                            if (ed == 1)
                            {
                                Console.WriteLine("Nuevo Precio: ");
                                pro.Price = (Numero(99999));
                            }
                            else
                            {
                                Console.WriteLine("Nuevo Stock: ");
                                pro.Stock = (Numero(99999));
                            }
                        }
                    }
                    break;

            }
        }

        public void Editar_cliente(int c, int co)
        {
            switch (c)
            {
                case 1:
                    Console.WriteLine("Ingrese los datos personales del Cliente: \n");
                    Console.WriteLine("\t Nombre: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Apellido: \n");
                    string last = Console.ReadLine();
                    Console.WriteLine("Id (Rut): \n");
                    int id = Numero(999999999);
                    Console.WriteLine("Fecha de Nacimiento: \n");
                    string formats = "yyyy/MM/dd";
                    string dateStrings = Console.ReadLine();
                    DateTime parsedDate; // duda con como funciona este comando
                    if (DateTime.TryParseExact(dateStrings, formats, null,
                                                System.Globalization.DateTimeStyles.AllowWhiteSpaces |
                                                System.Globalization.DateTimeStyles.AdjustToUniversal,
                                                out parsedDate))

                        Console.WriteLine("Nacionalidad: \n");
                    string nacion = Console.ReadLine();
                    clientes[co] = new Cliente(id, name, last, parsedDate, nacion);                   
                    break;

                case 2:
                    foreach (Cliente cl in clientes)
                    {
                        cl.Show_D();
                    }
                    break;

                case 3:                   
                    foreach (Producto produ in productos)
                    {
                        produ.Show_productos();
                        
                    }                    
                    break;

                case 4: //HACER COMPRA, AGREGAR A HISTORIAL
                    int hacer = 0;
                    bool g = true;
                    do
                    {
                        Console.WriteLine("\nIngrese el RUT del Cliente:\n");
                        int rut = Numero(999999999);
                        foreach (Cliente cc in clientes)
                        {
                            if (cc.Id == rut)
                            {
                                bool f = true;
                                do
                                {
                                    Console.WriteLine("Ingrse Rut del Cajero:\n");
                                    int rutt = Numero(999999999);
                                    foreach (Empleado em in empleados)
                                    {
                                        if (em.Id == rutt)
                                        {
                                            cc.Registro(new Compra(cc.Id, em.Id));
                                            cc.Historial[hacer].Hora_compra();
                                            int e;
                                            do
                                            {                                              
                                                Console.WriteLine("Seleccione una opcion:\n" +
                                                            "1 >> Agregar Producto\n" +
                                                            "2 >> Terminar Compra\n");
                                                e = Numero(2);
                                                if (e == 1)
                                                {
                                                    foreach (Producto produ in productos)
                                                    {
                                                        produ.Show_productos();

                                                    }
                                                    Console.WriteLine("Ingrese el Codigo del producto:\n");
                                                    int codee = Numero(999999);
                                                    Console.WriteLine("Ingrese la cantidad de unidades:\n");
                                                    int can = Numero(99999);
                                                    foreach (Producto produ in productos)
                                                    {
                                                        if (produ.Code == codee)
                                                        {
                                                            cc.Historial[hacer].Agregar_producto(produ, can);

                                                        }

                                                    }
                                                    
                                                }
                                            } while (e!=2);
                                            cc.Historial[hacer].Boleta(hacer, em, cc, cc.Historial[hacer]);
                                        }
                                        else
                                        {
                                            f = false;
                                        }
                                    }
                                } while (!f);
                            }
                            else
                            {
                                g = false;
                                Console.WriteLine("\n\nIngrese el RUT existente\n");

                            }
                        }
                    } while (!g);
                    break;

                case 5:
                    bool gg = true;
                    do
                    {
                        Console.WriteLine("\nIngrese el RUT del Cliente:\n");
                        int r = Numero(999999999);
                        foreach (Cliente cc in clientes)
                        {
                            if (cc.Id == r)
                            {
                                cc.Show_registro();
                            }
                            else
                            {
                                g = false;
                                Console.WriteLine("\n\nIngrese el RUT existente\n");

                            }

                        }
                    } while (!gg);
                    break;

                
            }
        }
    }
}
