using System;
using System.Collections.Generic;

namespace lab03
{
    public class Categorie
    {
        private string name;
        private List<Producto> elementos = new List<Producto>();

        public Categorie(string name, List<Producto> elementos)
        {
            this.name = name;
            this.elementos = elementos;
        }

        public string Name { get => name; set => name = value; }
        public List<Producto> Elementos { get => elementos; set => elementos = value; }

        public void Agregar_elemento(Producto p)
        {          
            elementos.Add(p);
        }       
    }
}
