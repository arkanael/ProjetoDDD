using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Contracts.Repositories;

namespace ProjetoDDD.Domain.Services
{
    public class DependenteService: BaseService<Dependente>
    {
        /// <summary>
        /// Atributo privado somente leitura para acessar os recursos do repositorio
        /// </summary>
        private readonly IDependenteRepository repository;
    }
}
