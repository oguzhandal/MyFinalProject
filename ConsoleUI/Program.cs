using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        //SOLID
        //Open Closed principle
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManeger categoryManeger = new CategoryManeger(new EfCategoryDal());
            foreach (var category in categoryManeger.GetAll().Data)
            {
                System.Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManeger productManeger = new ProductManeger(new EfProductDal(),
                new CategoryManeger(new EfCategoryDal()));

            var result = productManeger.GetProductDetails();
            if (result.Success == true)
            {
                foreach (var item in productManeger.GetProductDetails().Data)
                {
                    Console.WriteLine(item.CategoryName + " /" + item.ProductName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
