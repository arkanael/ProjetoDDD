using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDDD.Domain.Contracts.Repositories;

namespace ProjetoDDD.Domain.Services
{
    public abstract class BaseService<TEntity> where TEntity:class
    {
        private readonly IBaseReposirory<TEntity> repository;
    }
}
