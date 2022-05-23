using MertYazilim.DataAccess.Abstract;
using MertYazilim.DataAccess.Context.Abstract;
using MertYazilim.DataAccess.Context.MssqlContext;
using MertYazilim.Entities.Concrete.Log;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertYazilim.DataAccess.Concrete
{
    public class LogDal : ILogDal
    {
        private IDatabase _database;
        
        public LogDal(IDatabase database)
        {
            _database = database;
        }

        public void Add(Log log)
        {
            _database.Add(log);
        }

        public List<Log> GetAll()
        {
            return _database.GetAll();
        }
    }
}
