using Microsoft.EntityFrameworkCore;
using MyCart.Repository.Contracts;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace MyCart.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected MyCartDbContext MyCartDbContext { get; set; }

        public RepositoryBase(MyCartDbContext myCartDbContext)
        {
            MyCartDbContext = myCartDbContext;
        }

        public IQueryable<T> FindAll()
        {
            return MyCartDbContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return MyCartDbContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            MyCartDbContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            MyCartDbContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            MyCartDbContext.Set<T>().Remove(entity);
        }

        public void Save()
        {
            MyCartDbContext.SaveChanges();
        }
    }
}
