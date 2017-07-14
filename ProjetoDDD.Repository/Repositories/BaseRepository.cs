using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; //entityframework.. 
using ProjetoDDD.Domain.Contracts.Repositories; //interfaces.. 
using ProjetoDDD.Repository.Configurations; //datacontext

namespace ProjetoDDD.Repository.Repositories
{
    /// <summary>
    /// Classe abstrata para implementar o IBaseRepository
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class BaseRepository<TEntity> : IBaseReposirory<TEntity>, IDisposable where TEntity : class
    {
        /// <summary>
        /// Atributo de configuração do EntityFramework
        /// </summary>
        protected DataContext context;

        /// <summary>
        /// Atributo de para acesso a transações de objetos 
        /// </summary>
        protected DbContextTransaction transaction;

        public BaseRepository()
        {
            ///<summary>
            ///Inicializar o DataContext
            ///</summary>
            context = new DataContext();
        }
       

        public void BeginTrasaction()
        {
            transaction = context.Database.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Delete(TEntity obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public List<TEntity> FindAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public TEntity FindById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity obj)
        {
            context.Entry(obj).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Rollback()
        {
            if (transaction != null)
            {
                transaction.Rollback();
            }
        }

        public void Update(TEntity obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
