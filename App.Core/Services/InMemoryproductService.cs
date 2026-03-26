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
          if(product != null)
            {
                product.Id = GenerateId();
                _products.Add(product);
            }
            return product;
        }
     

        public bool Delete(string id)
        {
            Product prodToBeDeleted = GetById(id);
            _products.Remove(prodToBeDeleted);
            return true;
        }
        public Product GetById(string id)
        {
            Product? prod = _products.Find(p => p.Id == id);
            return prod;
        }
        public List<Product> GetAll()
        {
            return _products.OrderBy(p => p.Name).ToList();
        }
        public List<Product> Search(string text, ProductsCategoryEnum? category, ProductStatusEnum? status)
        {
            // LINQ
            List<Product> _filtered = _products.ToList();
            _filtered = _filtered.Where(p => p.Name.Contains(text)).ToList();

            if (category is not null)
            {
                _filtered = _filtered.Where(p => p.Category == category).ToList();
            }

            if (status is not null)
            {
                _filtered = _filtered.Where(p => p.Status == status).ToList();
            }

            return _filtered;
        }
        public bool Update(Product product)
        {
            if (product != null)
            {
                Product? existing = _products.Find(p => p.Id == product.Id);
                if (existing == null) return false;

                existing.Name = product.Name;
                existing.Category = product.Category;
                existing.Price = product.Price;
                existing.Status = product.Status;
                existing.Stock = product.Stock;

                return true;
            }
            return false;
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