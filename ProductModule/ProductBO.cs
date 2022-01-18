using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayaFurnitureStore.ProductModule
{
    public class ProductBO
    {
        public static List<Product> ProductList = new List<Product>
        {
            new Product("Round Table",10000,1),
            new Product("Elastic Chair",20000,2),
            new Product("Four Set chair",30000,3),
            new Product("Rolly Chair",30000,4),
            new Product("Rollable chair",30000,5),
            new Product("Cot",5000,6)
        };

        public Product Product { get; set; }

        public bool AddToCart(string ProductName,int ProductPrice,int Id)
        {
            Product product = new Product(ProductName, ProductPrice,Id);
            ProductList.Add(product);
            return true;
          
        }
        public Product FindID(int Id)
        {
            var product= (from k in ProductList
                        where k.Id1== Id
                        select k).FirstOrDefault();
            return product;
        }
        public List<Product> GetAllProducts()
        {
            if (ProductList.Count == 0)
            {
                return null;
            }
            else
            {
                return ProductList;
            }
        }
        /* public int BillCalci(List<Product> ProductList,int Id)
         {
             int amount;
             if (ProductList.Contains(Id))
             {
                 amount = ProductList.ProductPrice;

             }
             return amount;
         }
        */
        public override bool Equals(object obj)
        {
            return obj is ProductBO bO &&
                   EqualityComparer<Product>.Default.Equals(this.Product, bO.Product);
        }

        public override int GetHashCode()
        {
            return -957662036 + EqualityComparer<Product>.Default.GetHashCode(Product);
        }
    }
}
