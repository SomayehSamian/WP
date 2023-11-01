using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WorkProject.Domain.Models;
using WorkProject.Infrastructure.Context;
using WorkProject.Respositories.Interface;

namespace WorkProject.Infrastructure.Implimentation
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        #region Fields

        //protected readonly ApplicationDbContext _dbContext;
        protected DbContext _dbContext;
        protected readonly DbSet<T> entities;

        #endregion Fields

        #region Constructor

        protected GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            entities = dbContext.Set<T>();
        }

        #endregion Constructor

        #region Methods
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public  T Get(int id)
        {
            return entities.SingleOrDefault(x => x.Id.Equals(id));
        }
        public  IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            var query = entities.Where(predicate).AsEnumerable();
            return query;
        }

        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException();
            entities.Remove(entity);
            _dbContext.SaveChanges();
        }

        public void insert(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException();
            entities.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Remove(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException();
            entities.Remove(entity);

        }

        public void SaveChange()
        {
            _dbContext.SaveChanges();
        }

        public void update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException();
            entities.Update(entity);
            _dbContext.SaveChanges();
        }
        #endregion Methods
    }
}
