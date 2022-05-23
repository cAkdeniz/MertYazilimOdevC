using MertYazilim.Entities.Concrete.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertYazilim.DataAccess.Abstract
{
    public interface ILogDal
    {
        List<Log> GetAll();
        void Add(Log log);
    }
}
