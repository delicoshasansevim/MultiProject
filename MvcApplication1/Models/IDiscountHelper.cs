using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcApplication1.Models
{
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal total);
    }
}
