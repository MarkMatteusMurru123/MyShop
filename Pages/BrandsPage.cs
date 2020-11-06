using Data;
using Infra;
using Microsoft.EntityFrameworkCore;

namespace Pages
{
    public class BrandsPage : AbstractPage<BrandData>
    {
        public BrandsPage(ShopDbContext c) : base(c, c.Brands)
        {
            Caption = "Brands";

        }
    }
}