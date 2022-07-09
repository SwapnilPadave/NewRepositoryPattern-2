using NewRepo2.Repository.Repositories;
using NewRepo2.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepo2.Service.Services
{
    public class TMMService:ITMMService
    {
        private readonly ITeacherMappingModelRepository _tmmrepo;
        public TMMService(ITeacherMappingModelRepository tmmrepo)
        {
            _tmmrepo = tmmrepo;
        }
    }
}
