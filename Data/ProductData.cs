using Data.Abstractions;

namespace Data
{
    public class ProductData : NamedItemData
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUri { get; set; }
        public string CatalogTypeId { get; set; }
        public string CatalogBrandId{ get; set; }
    }
}