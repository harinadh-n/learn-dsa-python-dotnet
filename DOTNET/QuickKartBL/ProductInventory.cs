using System;

namespace QuickKartBL;

public class ProductInventory
{
    public int InventoryId { get; set; }
    public int QuantityInHand { get; set; }
    public ProductInventory(int inventoryId, int quantityInHand)
    {
        this.InventoryId = inventoryId;
        this.QuantityInHand = quantityInHand;
    }
}
