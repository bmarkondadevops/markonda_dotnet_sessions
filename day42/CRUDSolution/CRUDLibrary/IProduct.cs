using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDLibrary
{
    public interface IProduct
    {
        public void InsertProduct(Products product);
        public void UpdateProduct(int product);
        public void DeleteProduct();
        public List<Products> GetAllProducts();

    }
}
