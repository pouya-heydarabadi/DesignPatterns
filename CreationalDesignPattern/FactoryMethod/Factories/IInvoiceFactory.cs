using CreationalDesignPattern.FactoryMethod.Products;

namespace CreationalDesignPattern.FactoryMethod.Factories;

public interface IInvoiceFactory
{
    public IInvoice CreateInvoice();
} 