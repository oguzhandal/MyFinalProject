using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManeger productManeger = new ProductManeger(new EfProductDal());
            foreach (var item in productManeger.GetByUnitPrice(0,100))
            {
                System.Console.WriteLine("Category id: " + item.CategoryId + "-----" + "Product Name: " + item.ProductName);
            }
        }
    }
}
