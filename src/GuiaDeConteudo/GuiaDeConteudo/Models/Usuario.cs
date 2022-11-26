﻿using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace GuiaDeConteudo.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Obrigatório Informar o CPF")]
        public string cpf_usuario { get; set; }

        [Display(Name = "Perfil do Usuário")]
        [Required(ErrorMessage = "Obrigatório Informar o tipo")]
        public int tipo { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Obrigatório Informar o nome")]
        public string nome { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Obrigatório Informar a data de nascimento")]
        public DateTime dataNascimento { get; set; }

        [Display(Name = "e-mail")]
        [Required(ErrorMessage = "Obrigatório Informar a e-mail")]
        public string email { get; set; }

        [Display(Name = "Grau de Escolaridade")]
        [Required(ErrorMessage = "Obrigatório Informar o grau de escolaridade")]
        public int grauEscolaridade { get; set; }

        [Display(Name = "Formação/Profissão")]
        [Required(ErrorMessage = "Obrigatório Informar a Formação/Profissão")]
        public string formacao { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Obrigatório Informar a senha")]
        public string senha { get; set; }

        public ICollection<Avaliacao> Avaliacao { get; set; }
        public ICollection<Material> Material { get; set; }
    }
}
