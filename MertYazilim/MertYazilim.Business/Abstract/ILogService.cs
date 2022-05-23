using MertYazilim.Entities.Concrete.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertYazilim.Business.Abstract
{
    public interface ILogService
    {
        List<Log> GetAll();
        void Add(Log log);
    }
}
