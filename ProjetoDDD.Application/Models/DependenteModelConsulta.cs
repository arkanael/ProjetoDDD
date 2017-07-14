using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoDDD.Application.Models
{
    public class DependenteModelConsulta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
        public int IdFuncionario { get; set; }
        
    }
}