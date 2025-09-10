namespace CreationalDesignPattern.FactoryMethod.Products;

public sealed class InvoiceItem
{
    public InvoiceItem(string productCode, int quantity, decimal price)
    {
        ProductCode = productCode;
        Quantity = quantity;
        Price = price;
    }

    public string ProductCode { get; private set; }
    public int Quantity { get; private set; }
    public decimal Price { get; private set; }
}