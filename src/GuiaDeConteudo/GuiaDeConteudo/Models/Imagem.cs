using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuiaDeConteudo.Models
{
    public class Imagem
    {
        public string NomeArquivo { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }

        public class HttpPostedFileBase
        {
        }
    }

}
