using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Cadastro_Mvc.GenericRepository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _ctx;
        private DbSet<T> _dbSet;

        public Repository(DbContext ctx)
        {
            _ctx = ctx;
            _dbSet = _ctx.Set<T>();
        }

        public T Create(T entity)
        {
            _dbSet.Add(entity);
            _ctx.SaveChanges();

            return entity;
        }

        public T? GetById(Guid id)
        {
            return _dbSet.Find(id);
        }
    }
}
