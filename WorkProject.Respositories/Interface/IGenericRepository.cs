using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WorkProject.Domain.Models;

namespace WorkProject.Respositories.Interface
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
         IEnumerable<T> GetAll();

         T Get(int id);

         IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);

         void Delete(T entity);

        void insert(T entity);

        void Remove(T entity);

        void SaveChange();

        void update(T entity);

    }
}
