using CreationalDesignPattern.FactoryMethod.Products;

namespace CreationalDesignPattern.FactoryMethod.Factories;

public class PurchaseInvoiceFactory:IInvoiceFactory
{
    public IInvoice CreateInvoice()
    {
        return new PurchaseInvoice();
    }
}