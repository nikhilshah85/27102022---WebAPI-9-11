using System;
using System.Collections.Generic;

namespace DI_Demo.Models.EF
{
    public partial class Order
    {
        public int OId { get; set; }
        public int? OValue { get; set; }
        public int? OProduct { get; set; }
        public string? OCustomer { get; set; }
        public int? OQty { get; set; }

        public virtual Product? OProductNavigation { get; set; }
    }
}
