using System.ComponentModel.DataAnnotations;

namespace GuiaDeConteudo.Models
{
    public class AreaConhecimento
    {
        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

    }
}

