using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDDD.Application.Models
{
    public class DepedenteModelCadastro
    {
        [Required(ErrorMessage = "Informe o nome do dependente.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a data de nascimento do dependente.")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Informe o funcionário responsavél pelo dependente.")]
        public int IdFuncionario { get; set; }

    }
}