using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class LinqValueCalculator
    {
        public LinqValueCalculator() { }

        IDiscountHelper repo;
        public LinqValueCalculator(IDiscountHelper repoParam)
        {
            this.repo = repoParam;
        }



        public decimal ProductValue(List<Product>products)
        {
           decimal temp = repo.ApplyDiscount(products.Sum(x => x.price));
           return temp;
        }


    } // End of class
} // End of namespace