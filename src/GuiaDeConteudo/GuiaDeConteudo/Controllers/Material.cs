using GuiaDeConteudo.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuiaDeConteudo.Controllers
{
    [Table("Materiais")]
    public class Material
    {
        [Key]
        public int id_material { get; set; }
        public string cpf_usuario { get; set; }
        [ForeignKey("cpf_usuario")]
        public int status { get; set; }
        public int areaConhecimento { get; set; }
        public string titulo { get; set; }
        public string resumo { get; set; }
        public string link { get; set; }
        public string autor { get; set; }
        public string justificativaAnalise { get; set; }

        public Usuario Usuario { get; set; }
        public ICollection<Avaliacao> Avaliacao { get; set; }
    }
}
