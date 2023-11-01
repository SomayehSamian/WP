using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkProject.Services.Interface
{
    public interface ICustomService
    {
        string GetByLink(string Link);
        string GetByCode(string Code);
    }
}
