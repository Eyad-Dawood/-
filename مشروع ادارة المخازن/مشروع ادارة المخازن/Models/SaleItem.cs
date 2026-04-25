namespace InventoryManagement.Models
{
    public class SaleItem
    {
        public string Product_ID { get; set; }
        public string Product_Name { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal Total => Quantity * UnitPrice;
    }
}