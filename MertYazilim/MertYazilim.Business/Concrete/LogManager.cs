using MertYazilim.Business.Abstract;
using MertYazilim.DataAccess.Abstract;
using MertYazilim.Entities.Concrete.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertYazilim.Business.Concrete
{
    public class LogManager : ILogService
    {
        private ILogDal _logDal;
        public LogManager(ILogDal logDal)
        {
            _logDal = logDal;
        }

        public void Add(Log log)
        {
            _logDal.Add(log);
        }

        public List<Log> GetAll()
        {
            return _logDal.GetAll();
        }
    }
}
