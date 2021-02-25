using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        //SOLID
        //Open Closed principle
        static void Main(string[] args)
        {
            ProductManeger productManeger = new ProductManeger(new EfProductDal());
            foreach (var item in productManeger.GetAllByCategoryId(1))
            {
                System.Console.WriteLine("Category id: " + item.CategoryId + "-----" + "Category Name: " + item.ProductName);
            }
        }
    }
}
