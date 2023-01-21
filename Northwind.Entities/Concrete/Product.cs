﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities.Abstract;

namespace Northwind.Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 UnitsInStock { get; set; }
        public string QuantityPerUnit { get; set; } 
    }
}
