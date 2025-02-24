using System;

namespace QuickKartBL;

public class Seller
{
    public string SellerId { get; set; }
    public string SellerName { get; set; }

    public Seller(string sellerId, string sellerName)
    {
        this.SellerId = sellerId;
        this.SellerName = sellerName;
    }
}
