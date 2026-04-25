namespace InventoryManagement.Models
{
    public class Product
    {
        public string Product_ID { get; set; }
        public string Product_Name { get; set; }
        public int Quantity { get; set; }
        public int Minimum_Limit { get; set; }
        public decimal Price { get; set; }

        public bool IsLowStock => Quantity <= Minimum_Limit;
    }
}