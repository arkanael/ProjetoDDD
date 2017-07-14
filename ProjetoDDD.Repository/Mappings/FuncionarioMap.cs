using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ProjetoDDD.Domain.Entities;

namespace ProjetoDDD.Repository.Mappings
{
    public class FuncionarioMap:EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioMap()
        {
            ToTable("Funcionario");

            HasKey(funcionario => funcionario.Id);

            Property(funcionario => funcionario.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(50)
                .IsRequired();

            Property(funcionario => funcionario.Salario)
                .HasColumnName("Salario")
                .HasColumnType("money")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(funcionario => funcionario.DataAdmissao)
                .HasColumnName("DataAdmissao")
                .HasColumnType("date")
                .IsRequired();
        }
    }
}
