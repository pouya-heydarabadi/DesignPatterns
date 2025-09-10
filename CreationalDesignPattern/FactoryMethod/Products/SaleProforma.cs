namespace CreationalDesignPattern.FactoryMethod.Products;

public class SaleProforma:IInvoice
{
    public Guid Id { get; } = Guid.NewGuid();
    public DateTime IssueDate { get; } = DateTime.Now;
    public List<InvoiceItem> InvoiceItems { get; set; } = new();

    public void AddItem(string productCode, int quantity, decimal price)
        => this.InvoiceItems.Add(new InvoiceItem(productCode, quantity, price));


    public decimal GetTotalSum()
        => this.InvoiceItems.Sum(x => x.Price * x.Quantity) * 1.1m;

    public string GetInvoiceType()
        => nameof(SaleProforma);
}