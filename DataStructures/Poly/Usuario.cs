using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Poly
{

    public interface IComentario
    {
        void agregarComentario(string comentario);
    }

    public class InstagramAccount : Usuario, IComentario
    {
        private List<string> comentarios = new List<string>();
        public InstagramAccount(string name, int age) : base(name,age) {}
        public void agregarComentario(string comentario)
        {
            comentarios.Add(comentario);
        }

        public void mostrarComentarios()
        {
            foreach (string comentario in comentarios)
            {
                Console.WriteLine(comentario);
            }
        }
    }

    public class Usuario
    {
        public string Name { get; private set; }
        public int Age { get; set; }

        private readonly int Id;

        static int IdCounter = 1;

        public Usuario(string name, int age)
        {
            Name = name;
            Age = age;
            Id = IdCounter;
            IdCounter++;
        }
        public virtual void changeName(string name)
        {
            Name = name;
        }
        public void GetId()
        {
            Console.WriteLine(Id);
        }
    }
}
