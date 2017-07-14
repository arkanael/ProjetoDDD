using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Contracts.Repositories;

namespace ProjetoDDD.Domain.Services
{
    class FuncionarioService: BaseService<Funcionario>
    {
        private readonly IFuncionarioRepository repository;
    }
}
