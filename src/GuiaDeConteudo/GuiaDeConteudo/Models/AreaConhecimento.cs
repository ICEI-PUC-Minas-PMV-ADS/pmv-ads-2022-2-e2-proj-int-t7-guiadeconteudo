using System.ComponentModel.DataAnnotations;

namespace GuiaDeConteudo.Models
{
    public class AreaConhecimento
    {
        [Key]
        public int Area_id { get; set; }

        public string Area_nome { get; set; }

    }
}

