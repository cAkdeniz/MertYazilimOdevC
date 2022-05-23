using MertYazilim.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertYazilim.Entities.Concrete.Log
{
    public class Log: ILog, IEntity
    {
        public int Id { get; set; }
        public string Method { get; set; }
        public string Path { get; set; }
        public string Query { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
    }
}
