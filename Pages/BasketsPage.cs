using Data;
using Infra;

namespace Pages
{
    public class BasketsPage : AbstractPage<BasketData>
    {
        public BasketsPage(ShopDbContext c) : base(c, c.Baskets)
        {
            Caption = "Baskets";
        }
    }
}