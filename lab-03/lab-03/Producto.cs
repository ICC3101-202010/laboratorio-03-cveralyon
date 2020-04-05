using System;
namespace lab03
{
    public class Producto
    {
        private int code;
        private string name;
        private int price;
        private string brand;
        private int stock;
        private string categorie;
        private bool aux1;

        public Producto(int code, string name, int price, string brand, int stock, string categorie, bool aux1)
        {
            this.code = code;
            this.name = name;
            this.price = price;
            this.brand = brand;
            this.stock = stock;
            this.categorie = categorie;
            this.aux1 = aux1;
        }

        public int Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public bool Aux1 { get => aux1; set => aux1 = value; }

        public void Enrolar(int i)// hacer un contador afuera que ingrese cada vez que se enrrola un producto
        {
            while (aux1)
            {
                int cat;
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
                        categorie = "Bebestible";
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

                Console.WriteLine("\nIngrese el nombre del prodcuto:");
                name = Console.ReadLine();

                Console.WriteLine("\nIngrese la Marca del Producto: " );
                brand = Console.ReadLine();

                Console.WriteLine("\nIngrese el Precio de Venta del Producto ( Ingrese el valor sin numero ni coma) : ");
                price = int.Parse(Console.ReadLine());

                Console.WriteLine("\nIngrese el Stock inicial del Producto ( Ingrese el valor sin numero ni coma) : ");
                stock = int.Parse(Console.ReadLine());

                code = 999999 - i;
                Console.WriteLine("El codigo generado para el producto ingresado es: {0} ", code);
            }

        }

        

    }    
}
