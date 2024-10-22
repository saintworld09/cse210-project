public class Product
{
    private string name;
    private int productId;
    private decimal price;
    private int quantity;

    public Product(string name, int productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public decimal CalculateTotalCost()
    {
        return price * quantity;
    }

    public string GetProductDetails()
    {
        return $"{name} (ID: {productId}) - Quantity: {quantity}, Cost: ${CalculateTotalCost():0.00}";
    }
}
