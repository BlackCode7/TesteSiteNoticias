using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteSiteNoticias.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Titulo { get; set; }
        public string Resumo { get; set; }
        public string Conteudo { get; set; }
        public string Imagem { get; set; }
    }
}
