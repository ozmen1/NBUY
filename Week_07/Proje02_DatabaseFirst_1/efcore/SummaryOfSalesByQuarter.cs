﻿using System;
using System.Collections.Generic;

namespace Proje02_DatabaseFirst_1.efcore
{
    public partial class SummaryOfSalesByQuarter
    {
        public DateTime? ShippedDate { get; set; }
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
