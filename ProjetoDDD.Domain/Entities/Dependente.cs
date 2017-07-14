using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Entities
{
    /// <summary>
    /// Modelagem de Entidade
    /// </summary>
    public class Dependente:BaseEntities
    {
        public DateTime DataNascimento { get; set; }
       
        /// <summary>
        /// Dependente tem 1  tem um Funcionario
        /// </summary>
        public Funcionario Funcionario { get; set; }
         
    }
}
