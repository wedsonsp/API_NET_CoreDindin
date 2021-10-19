using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDindin.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Titulo { get; set; }
        public string UploadCapa { get; set; }
        public string Professor { get; set; }
        public string Descricao { get; set; }
    }
}
