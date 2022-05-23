using MertYazilim.Entities.Concrete.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertYazilim.DataAccess.Context.Abstract
{
    public interface IDatabase
    {
        List<Log> GetAll();
        void Add(Log log);
    }
}
