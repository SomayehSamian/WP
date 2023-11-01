using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WorkProject.Domain.Models;

namespace WorkProject.Respositories.Interface
{
    public interface ICustomeRepository:IGenericRepository<CustomModel>
    {
        CustomModel GetBy(Expression<Func<CustomModel, bool>> predicate);
    }
}
