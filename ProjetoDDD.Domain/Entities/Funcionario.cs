using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDDD.Domain.Entities;

namespace ProjetoDDD.Domain.Entities
{
    /// <summary>
    /// Modelagem de Entidades
    /// </summary>
    public class Funcionario : BaseEntities
    {
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        ///<summary>
        ///Funcionario pode ter 0 ou muitos Dependentes
        /// </summary>
        public ICollection<Dependente> Dependentes { get; set; }

    }
}
