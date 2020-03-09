using System;
using System.Collections.Generic;
using RequestApi.Models;


namespace RequestApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string Title { get; set; }
        public int TotalItens { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}