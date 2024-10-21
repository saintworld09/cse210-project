using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal CalculateTotalPrice()
    {
        decimal totalCost = 0;

        foreach (var product in products)
        {
            totalCost += product.CalculateTotalCost();
        }

        // Add shipping cost
        decimal shippingCost = customer.LivesInUSA() ? 5.00m : 35.00m;
        return totalCost + shippingCost;
    }

    public string GeneratePackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += product.GetProductDetails() + "\n";
        }
        return label;
    }

    public string GenerateShippingLabel()
    {
        return "Shipping Label:\n" + customer.GetCustomerDetails();
    }
}
