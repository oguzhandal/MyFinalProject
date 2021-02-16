using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManeger productManeger = new ProductManeger(new InMemoryProductDal());
            foreach (var item in productManeger.GetAll())
            {
                System.Console.WriteLine("Product Name: "+item.ProductName +" | Unit Stock: "+item.UnitInStock + " | Unit Price: " +item.UnitPrice);
            }
        }
    }
}
