using CreationalDesignPattern.FactoryMethod.Products;

namespace CreationalDesignPattern.FactoryMethod.Factories;

public class SaleProformaFactory:IInvoiceFactory
{
    public IInvoice CreateInvoice()
    {
        return new SaleProforma();
    }
}