﻿using MertYazilim.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertYazilim.Entities.Concrete
{
    public class Address
    {
        public string? Street { get; set; }
        public string City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string Country { get; set; }
        public string? Phone { get; set; }
    }
}
