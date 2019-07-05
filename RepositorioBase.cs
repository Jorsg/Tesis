using Dominio;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;

namespace Repository
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : class
    {
        /// <summary>
        /// 
        /// </summary>
        private bool _disposed;

        /// <summary>
        /// 
        /// </summary>
        protected readonly ML_TesisEntities Contexto = new ML_TesisEntities();


        public void  Guardar(T entidad)
        {
            Contexto.Set<T>().Add(entidad);
            Contexto.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parametros"></param>
        /// <returns></returns>
        public IQueryable<T> FindBy(Expression<Func<T, bool>> parametros)
        {
            return Contexto.Set<T>().Where(parametros);
        }

        public IQueryable<T> GetAll()
        {
            return Contexto.Set<T>();
        }

        public IQueryable<T> GetAll(List<Expression<Func<T, object>>> inclusiones)
        {
            List<string> lista = new List<string>();

            foreach (MemberExpression item in inclusiones.Select(a => a.Body as MemberExpression))
            {
                if (item == null)
                {
                    throw new ArgumentException("Exception del método");
                }

                lista.Add(item.Member.Name);
            }
            DbQuery<T> query = Contexto.Set<T>();
            lista.ForEach(x => query = query.Include(x));

            return query;
        }

        /// <summary>
        /// Obtiene un registro en base a los parámetros especificados
        /// </summary>
        /// <param name="parametros">Parámetros de búsqueda</param>
        /// <returns>Registro encontrado</returns>
        public T Single(Expression<Func<T, bool>> parametros)
        {
            return Contexto.Set<T>().FirstOrDefault(parametros);

        }

        public void Update(T entidad)
        {
            Contexto.Entry(entidad).State = EntityState.Modified;
            Contexto.SaveChanges();
        }

        public T GetT(long id)
        {
            return Contexto.Set<T>().Find(id);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
