using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkProject.Domain.Models;
using WorkProject.Respositories.Interface;
using WorkProject.Services.Interface;

namespace WorkProject.Services.Implimantation
{
    public  class CustomService: ICustomService
    {
        private readonly ICustomeRepository _customRepository;

        public CustomService(ICustomeRepository customRepository)
        {
            _customRepository = customRepository;
        }

        public string GetByCode(string code)
        {
            CustomModel custom = _customRepository.GetBy(x => x.Code.Equals(code));
            return custom.link;
        }

        public string GetByLink(string link)
        {
            CustomModel custom = _customRepository.GetBy(x => x.link.Equals(link));
            return custom.Code;
        }
    }
}
