using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS1_Future_Work
{
    public abstract class Usuario
    {
        public string Nome { get; set; }
        public string Senha { get; set; }

        public string Tipo { get; set; }

        public override string ToString()
        {
            return $"{Nome} ({Tipo})";
        }
    }
    public static class Repositorio
    {
        public static List<Usuario> Usuarios { get; } = new List<Usuario>();

        public static List<Curso> Cursos { get; } = new List<Curso>();
    }

}
