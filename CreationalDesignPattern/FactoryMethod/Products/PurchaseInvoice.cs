namespace CreationalDesignPattern.FactoryMethod.Products;

public class PurchaseInvoice:IInvoice
{
        public Guid Id { get; } = Guid.NewGuid();
        public DateTime IssueDate { get; } = DateTime.Now;
        public List<InvoiceItem> InvoiceItems { get; set; } = new();

        public void AddItem(string productCode, int quantity, decimal price)
        {
            if (price < 100_000_000)
                throw new Exception(
                    $"Your Produce Cannot Be Applied .. Because Your Product Price Is Less Than 100_000_000 Rial {productCode}");
            
            this.InvoiceItems.Add(new InvoiceItem(productCode, quantity, price));
        }


        public decimal GetTotalSum()
            => this.InvoiceItems.Sum(x => x.Price * x.Quantity) * 1.09m;

        public string GetInvoiceType()
            => nameof(PurchaseInvoice);
}