using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductNUnitApplication.Models.Product
{
    public class Customer
    {
        public CustomerType CustomerType { get; set; }

    }
    public enum CustomerType { Regular, Premium }
}
