using CreationalDesignPattern.FactoryMethod.Factories;
using CreationalDesignPattern.FactoryMethod.Products;

SaleProformaFactory proformaFactory = new();
IInvoice saleProforma = proformaFactory.CreateInvoice();

saleProforma.AddItem("hi", 12, 13000);
