using System;
using Data.Abstractions;

namespace Data
{
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