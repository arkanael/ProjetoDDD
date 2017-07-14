using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.ModelConfiguration;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Repository.Mappings;

namespace ProjetoDDD.Repository.Configurations
{
    /// <summary>
    /// ClaSse para a configuração do contexto do EntityFramework
    /// </summary>
    public class DataContext:DbContext
    {
        /// <summary>
        /// Contrutor envia o nome da connectionstring para a super classe
        /// </summary>
        public DataContext():base("DataBase")
        {

        }

        ///<summary>
        ///sobrescrever o método OnModelCreating definido as classes de mapeamento do projeto
        ///
        ///</summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FuncionarioMap());
            modelBuilder.Configurations.Add(new DependenteMap());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Dependente> Dependente { get; set; }

    }
}
