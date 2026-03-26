using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Services
{
    public class InMemoryProductService : IProductService
    {
        private List<Product> _products;

        public InMemoryProductService()
        {
            _products = new List<Product>();
            GenerateFakeProducts();
        }
        public Product Add(Product product)
        {
            throw new NotImplementedException();
            //products.Add(product);
            //return product;
        }

        public bool Delete(string id)
        {
            //return false;
            throw new NotImplementedException();
        }
        public Product GetById(string id)
        {
            throw new NotImplementedException();
        }
        public List<Product> GetAll()
        {
            return _products.OrderBy(p => p.Name).ToList();
        }
        public List<Product> Search(string text, ProductsCategoryEnum? category, ProductStatusEnum? status)
        {
            throw new NotImplementedException();
        }
        public bool Update(Product product)
        {
            throw new NotImplementedException();
        }
        public void GenerateFakeProducts()
        {
            _products.Clear();
            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "Laptop",
                Category = ProductsCategoryEnum.Electronics,
                Price = 150000.00m,
                Stock = 10,
                Status = ProductStatusEnum.Active,

            });

            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "Jacket",
                Category = ProductsCategoryEnum.Clothing,
                Status = ProductStatusEnum.Active,
                Price = 4500m,
                Stock = 10,


            });

        }

        private string GenerateId()
        {
            // e.g., P-1A2B3C
            return "P-" + Guid.NewGuid().ToString("N").Substring(0, 6);
        }
    }
}