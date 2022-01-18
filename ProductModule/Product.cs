/*
 * Application : online furniture Store
 * AuthorName: Nandhini sundram
 * Reviewed by :
 * Created on : 03-Jan-2021
 * Updated on : 12-Jan-2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayaFurnitureStore.ProductModule
{
   public class Product
    {
        string ProductName;
        int ProductPrice;
        int Id;
        public Product() { }
        public Product(string productName, int productPrice,int Id)
        {
            ProductName1 = productName;
            ProductPrice1 = productPrice;
            Id1 = Id;
        }

        public string ProductName1 { get => ProductName; set => ProductName = value; }
        public int ProductPrice1 { get => ProductPrice; set => ProductPrice = value; }
        public int Id1 { get => Id; set => Id = value; }

        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   ProductName == product.ProductName &&
                   ProductPrice == product.ProductPrice;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2}", ProductName, ProductPrice,Id);
        }
    }
}
