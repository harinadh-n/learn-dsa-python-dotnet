using System;

namespace QuickKartBL;

public class Product
{
    public string Description { get; set; }
    public double Price { get; set; }
    public string ProductId { get; set; }
    public string ProductName { get; set; }
    public Product(string productId, string productName, string description, double price)
    {
        this.ProductId = productId;
        this.ProductName = productName;
        this.Description = description;
        this.Price = price;
    }
}
