using Microsoft.EntityFrameworkCore;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Infra.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        //private readonly SqlContext sqlContext;
        protected SqlContext sqlContext = new SqlContext();
        public RepositoryBase(SqlContext _sqlContext)
        {
            sqlContext = _sqlContext;
        }

        public void Add(T obj)
        {
            try
            {
                sqlContext.Set<T>().Add(obj);
                sqlContext.SaveChanges();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return sqlContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return sqlContext.Set<T>().Find(id);
        }

        public void Remove(T obj)
        {
            try
            {
                sqlContext.Set<T>().Remove(obj);
                sqlContext.SaveChanges();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void Update(T obj)
        {
            try
            {
                sqlContext.Entry(obj).State = EntityState.Modified;
                sqlContext.SaveChanges();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
    }
}
