using System;

namespace QuickKartBL;

public class Purchase
{
    public DateTime DateOfPurchase { get; set; }
    public string PaymentType { get; set; }
    public string PurchaseId { get; set; }
    public int QuantityOrdered { get; set; }
    public string ShippingAddress { get; set; }

    public Purchase(string purchaseId, int quantityOrdered, string shippingAddress, DateTime dateOfPurchase, string paymentType)
    {
        this.PurchaseId = purchaseId;
        this.QuantityOrdered = quantityOrdered;
        this.ShippingAddress = shippingAddress;
        this.DateOfPurchase = dateOfPurchase;
        this.PaymentType = paymentType;
    }
    public double CaluculateBillAmount(double price){
        double totalPrice = QuantityOrdered * price;
        return totalPrice;
    }
}
