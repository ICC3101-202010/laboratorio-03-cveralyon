using System;
using System.Collections.Generic;

namespace lab03
{
    public class Producto
    {
        private int code;
        private string name;
        private int price;
        private string brand;
        private int stock;
        private bool aux1;

        public Producto(int code, string name, int price, string brand, int stock, bool aux1)
        {
            this.code = code;
            this.name = name;
            this.price = price;
            this.brand = brand;
            this.stock = stock;
            this.aux1 = aux1;
        }

        public int Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Stock { get => stock; set => stock = value; }
        public bool Aux1 { get => aux1; set => aux1 = value; }

        public void Enrolar(int i)// hacer un contador afuera que ingrese cada vez que se enrrola un producto
        {
            Console.WriteLine("\nIngrese el nombre del prodcuto:");
            name = Console.ReadLine();

            Console.WriteLine("\nIngrese la Marca del Producto: ");
            brand = Console.ReadLine();

            do           {
                string p;
                Console.WriteLine("\nIngrese el Precio de Venta del Producto ( Ingrese el valor sin numero ni coma) : ");
                p = Console.ReadLine();
                aux1 = int.TryParse(p, out price);
                if (aux1 == false) { Console.WriteLine("---ERROR: INGRESE SOLO NUMEROS---"); }
            } while (!aux1);
            do            {
                string p;
                Console.WriteLine("\nIngrese el Stock inicial del Producto ( Ingrese el valor sin numero ni coma) : ");
                p = Console.ReadLine();
                aux1 = int.TryParse(p, out stock);
                if (aux1 == false) { Console.WriteLine("---ERROR: INGRESE SOLO NUMEROS---"); }
            } while (!aux1);           
            code = 999999 - i;
            Console.WriteLine("El codigo generado para el producto ingresado es: {0} ", code);

        }
        
        public void Show_productos()
        {
            
        }
    }    
}
