using System;
namespace lab03
{
    public abstract  class Persona
    {
        private int id;
        private string name;
        private string last;
        private DateTime birth;
        private string nacion;

        protected int Id { get => id; set => id = value; }
        protected string Name { get => name; set => name = value; }
        protected string Last { get => last; set => last = value; }
        protected DateTime Birth { get => birth; set => birth = value; }
        protected string Nacion { get => nacion; set => nacion = value; }

        protected Persona(int id, string name, string last, DateTime birth, string nacion)
        {
            this.id = id;
            this.name = name;
            this.last = last;
            this.birth = birth;
            this.nacion = nacion;
        }
    }
}
