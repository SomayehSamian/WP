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
    public class CustomRepository:GenericRepository<CustomModel>, ICustomeRepository
    {
        private readonly ApplicationDbContext _dbContext;

        #region Constructor
        public CustomRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion Constructor
        #region Methods

        public CustomModel GetBy(Expression<Func<CustomModel, bool>> predicate)
        {
            return FindBy(predicate).Any()? FindBy(predicate).First():new CustomModel();
        }
        #endregion Methods
    }
}
