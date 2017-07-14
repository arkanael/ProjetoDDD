using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ProjetoDDD.Application.Models.Funcionario
{
    public class FuncionarioModelEdicao
    {
        [Required(ErrorMessage ="Informe o Id do funcionário.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do funcionário.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o salário do funcionário.")]
        public decimal Salario { get; set; }

        [Required(ErrorMessage = "Informe a data de admissão do funcionário.")]
        public DateTime DataAdmissao { get; set; }
    }
}