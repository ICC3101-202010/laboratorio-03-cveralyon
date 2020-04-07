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

        public Producto(int code, string name, int price, string brand, int stock)
        {
            this.code = code;
            this.name = name;
            this.price = price;
            this.brand = brand;
            this.stock = stock;
        }

        public int Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Stock { get => stock; set => stock = value; }
        public bool Aux1 { get => aux1; set => aux1 = value; }
       
        public void Show_productos()
        {
            Console.WriteLine("  ------------------------------------------------------------------  ");
            Console.WriteLine(" STOCK  --     NOMBRE   --   MARCA    --    CODIGO   --   PRECIO     ");
            Console.WriteLine("  {0}   --      {1}    --   {2}      --    {3}      --   {4}     ", stock, name, brand, code, price);
            Console.WriteLine("  ------------------------------------------------------------------  ");


        }
    }    
}
