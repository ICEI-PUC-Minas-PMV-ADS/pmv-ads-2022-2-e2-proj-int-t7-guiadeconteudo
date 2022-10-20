using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using GuiaDeConteudo.Models;

namespace GuiaDeConteudo.Controllers
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public string cpf_usuario { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar o CPF")]
        public int tipo { get; set; }
        public string nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public string email { get; set; }
        public int grauEscolaridade { get; set; }
        public string formacao { get; set; }
        public string senha { get; set; }

        public ICollection<Avaliacao> Avaliacoes { get; set; }
        public ICollection<Material> Materiais { get; set; }
    }
}
