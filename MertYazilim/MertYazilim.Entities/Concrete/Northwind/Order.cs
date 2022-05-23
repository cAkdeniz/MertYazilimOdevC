using MertYazilim.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertYazilim.Entities.Concrete
{
    public class Order: IEntity
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public string? ShippedDate { get; set; }
        public string ShipVia { get; set; }
        public decimal Freight { get; set; }
        public string ShipName { get; set; }
        public ShipAddress ShipAddress { get; set; }
        
        public List<OrderDetail> Details { get; set; }
    }
}
