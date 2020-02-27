﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnPointSport.Core.Models
{
    public class ImportItemDetial
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string ImportCode { get; set; }
        public string ProductServiceCode { get; set; }
        public Double Quantity { get; set; }
        public Double UnitPrice { get; set; }
        public Double Price { get; set; }
        public Boolean Active { get; set; }
        public string Description { get; set; }
    }
}
