using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDindin.Models
{
    public class Aula
    {
        public int AulaId { get; set; }
        public string TituloAula { get; set; }
        public string LinkAula { get; set; }
        public string DescricaoAula { get; set; }
        public int CursoId { get; set; }
    }
}
