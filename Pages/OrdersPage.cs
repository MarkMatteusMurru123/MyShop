using Data;
using Infra;

namespace Pages
{
    public class OrdersPage : AbstractPage<OrderData>
    {
        public OrdersPage(ShopDbContext c) : base(c,c.Orders)
        {
            Caption = "Orders";

        }
    }
}