using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ProjetoDDD.Domain.Entities;

namespace ProjetoDDD.Repository.Mappings
{
    /// <summary>
    /// Classe de mapeamento para a entidade Dependente
    /// </summary>
    public class DependenteMap:EntityTypeConfiguration<Dependente>
    {
        public DependenteMap()
        {
            ToTable("Dependente");

            HasKey(dependente => dependente.Id);

            Property(dependente => dependente.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(50)
                .IsRequired();

            Property(dependente => dependente.DataNascimento)
                .HasColumnName("DataNascimento")
                .HasColumnType("date")
                .IsRequired();

            HasRequired(dependente => dependente.Funcionario)
                .WithMany(funcionario => funcionario.Dependentes)
                .HasForeignKey(dependente => dependente.IdFuncionario);
        }
    }
}
