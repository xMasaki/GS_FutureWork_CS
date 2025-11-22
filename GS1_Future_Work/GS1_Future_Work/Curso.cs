using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS1_Future_Work
{
    public class Curso
    {
        public string Titulo {  get; set; }
        public string Professor { get; set; }
        public string Duracao { get; set; }

        public override string ToString()
        {
            return $"{Titulo} - {Professor} ({Duracao})";
        }

    }
}