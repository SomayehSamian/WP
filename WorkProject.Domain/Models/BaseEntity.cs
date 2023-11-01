using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkProject.Domain.Models
{
    public class BaseEntity
    {
        public BaseEntity()
        {
          this.CreatedDate = DateTime.UtcNow;
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
