using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Contracts.Repositories
{
    /// <summary>
    /// 
    /// Bases (Super types) 
    /// Criando sempre interfaces ou classes genericas que façam um supertipo para outras mais especificas,
    /// eliminando a redundancia de codigo.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// 
    public interface IBaseReposirory<TEntity> where TEntity : class
    {
        /// <summary>
        /// Métodos genericos para implementar o Insert(Inserção) de dados 
        /// </summary>
        /// <param name="obj"></param>
        void Insert(TEntity obj);

        /// <summary>
        /// Método generico para implentar o Update de dados
        /// </summary>
        /// <param name="obj"></param>
        void Update(TEntity obj);

        /// <summary>
        /// Método generico para implentar o Delete de dados
        /// </summary>
        /// <param name="obj"></param>
        void Delete(TEntity obj);

        /// <summary>
        /// Método generico para implentar o FindAll(Busca todos) os dados
        /// </summary>
        /// <param name="obj"></param>
        List<TEntity> FindAll();

        /// <summary>
        /// Método generico para implentar o FindId para buscar dados pelo id
        /// </summary>
        /// <param name="obj"></param>
        TEntity FindById(int id);

        /// <summary>
        /// Método generico para Iniciar uma transação
        /// </summary>
        /// <param name="obj"></param>
        void BeginTrasaction();

        /// <summary>
        /// Método generico para implentar o Commit de dados
        /// </summary>
        /// <param name="obj"></param>
        void Commit();

        /// <summary>
        /// Método generico para implentar o Rollback de dados
        /// </summary>
        /// <param name="obj"></param>
        void Rollback();
    }
}
