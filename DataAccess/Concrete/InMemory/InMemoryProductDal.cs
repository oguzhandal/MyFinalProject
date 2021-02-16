using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product {ProductId=1,CategoryId=1,ProductName="Laptop",UnitInStock=10,UnitPrice=4500},
                new Product {ProductId=2,CategoryId=1,ProductName="Telefon",UnitInStock=100,UnitPrice=7000},
                new Product {ProductId=3,CategoryId=2,ProductName="Klavye",UnitInStock=15,UnitPrice=170},
                new Product {ProductId=4,CategoryId=2,ProductName="Yazıcı",UnitInStock=1,UnitPrice=350},
                new Product {ProductId=5,CategoryId=2,ProductName="Mause",UnitInStock=50,UnitPrice=150},

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllCaategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;
        }
    }
}
