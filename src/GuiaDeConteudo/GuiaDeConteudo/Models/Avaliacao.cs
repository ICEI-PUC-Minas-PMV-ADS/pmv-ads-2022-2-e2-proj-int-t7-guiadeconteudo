using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuiaDeConteudo.Models
{
    [Table("Avaliacoes")]
    public class Avaliacao
    {
        [Key]
        public int id_avalicao { get; set; }
        public int id_material { set; get; }
        [ForeignKey("id_material")]

        public string cpf_usuario { get; set; }
        [ForeignKey(" cpf_usuario")]
        public int rate { get; set; }
        public string justificativaAvaliacao { get; set; }

        public Usuario Usuario { get; set; }
        public Material Material { get; set; }
    }
}
