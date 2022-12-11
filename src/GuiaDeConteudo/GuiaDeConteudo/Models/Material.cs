using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuiaDeConteudo.Models
{
    [Table("Materiais")]
    public class Material
    {
        [Key]
        public int id_material { get; set; }

        [Display(Name = "CPF")]
        [ForeignKey("cpf_usuario")]
        public string cpf_usuario { get; set; }
       
        public int status { get; set; }

        [Display(Name = "Area de Conhecimento")]
        public int areaConhecimento { get; set; }

        [Display(Name = "Título")]
        public string titulo { get; set; }

        [Display(Name = "Resumo")]
        public string resumo { get; set; }

        [Display(Name = "Link")]
        public string link { get; set; }

        [Display(Name = "Autor")]
        public string autor { get; set; }
        public string justificativaAnalise { get; set; }

        public Usuario Usuario { get; set; }
        public ICollection<Avaliacao> Avaliacao { get; set; }
    }
}
