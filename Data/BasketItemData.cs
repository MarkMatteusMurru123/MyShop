using System;

namespace Data
{
    public class UniqueItemData
    {
        public string Id { get; set; }

    }
    public class NamedItemData : UniqueItemData
    {
        public string Name { get; set; }

    }

    public class BasketItemData : UniqueItemData
    {
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string CatalogItemId { get; set; }
        public string BasketId { get; set; }
    }
    public class BasketData : UniqueItemData
    {
        public string BuyerId { get; set; }
    }
    public class CatalogData : NamedItemData
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUri { get; set; }
        public string CatalogTypeId { get; set; }
        public string CatalogBrandId{ get; set; }
    }
    public class CatalogBrandData : NamedItemData
    {

    }
    public class CatalogTypeData: NamedItemData
    {

    }
    public class OrderItemData : UniqueItemData
    {
        public string CatalogItemId { get; set; }
        public string ProductName { get; set; }
        public string PictureUri { get; set; }
        public decimal UnitPrice { get; set; }
        public int Units { get; set; }
        public string OrderId { get; set; }

    }
    public class OrderData : UniqueItemData
    {
        public string BuyerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }


    }
}
