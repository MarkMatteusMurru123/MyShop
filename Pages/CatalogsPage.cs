using Data;
using Infra;

namespace Pages
{
    public class CatalogsPage : AbstractPage<CatalogData>
    {
        public CatalogsPage(ShopDbContext c) : base(c, c.Catalogs)
        {
            Caption = "Catalogs";

        }
    }
}