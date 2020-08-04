using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class DiscountHelper : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal total)
        {
            return total + 0.9M;
        }
    }
}