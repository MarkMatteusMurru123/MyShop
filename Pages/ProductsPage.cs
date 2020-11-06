using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Infra;

namespace Pages
{
    public class ProductsPage : AbstractPage<ProductData>
    {
        public ProductsPage(ShopDbContext c):base(c,c.Products)
        {
            Caption = "Products";

        }
    }
}