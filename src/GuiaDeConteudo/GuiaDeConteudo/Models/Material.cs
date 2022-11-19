using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.Threading.Tasks;


namespace GuiaDeConteudo.Models
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

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ImageName { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
        public Usuario Usuario { get; set; }
        private ICollection<Material> material;

        public ICollection<Material> GetMaterial()
        {
            return material;
        }

        public void SetMaterial(ICollection<Material> value)
        {
            material = value;
        }

        public ICollection<Avaliacao> Avaliacao { get; set; }
    }
}
