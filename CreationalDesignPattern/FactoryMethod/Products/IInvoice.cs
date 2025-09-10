namespace CreationalDesignPattern.FactoryMethod.Products;

public interface IInvoice
{
    Guid Id { get; }
    DateTime IssueDate { get; }
    List<InvoiceItem> InvoiceItems { get; set; }
    void AddItem(string productCode, int quantity, decimal price);
    decimal GetTotalSum();
    string GetInvoiceType();
}