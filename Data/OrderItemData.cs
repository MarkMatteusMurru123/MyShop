using Data.Abstractions;

namespace Data
{
    public class OrderItemData : UniqueItemData
    {
        public string CatalogItemId { get; set; }
        public string ProductName { get; set; }
        public string PictureUri { get; set; }
        public decimal UnitPrice { get; set; }
        public int Units { get; set; }
        public string OrderId { get; set; }

    }
}