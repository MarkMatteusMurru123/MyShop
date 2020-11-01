using Data.Abstractions;

namespace Data
{
    public class BasketItemData : UniqueItemData
    {
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string CatalogItemId { get; set; }
        public string BasketId { get; set; }
    }
}
