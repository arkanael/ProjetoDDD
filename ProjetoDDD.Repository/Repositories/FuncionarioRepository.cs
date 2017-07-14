using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Contracts.Repositories;

namespace ProjetoDDD.Repository.Repositories
{
    class FuncionarioRepository:BaseRepository<Funcionario>, IFuncionarioRepository
    {

    }
}
