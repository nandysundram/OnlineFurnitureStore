using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MayaFurniturestore.MenuModule;
using MayaFurnitureStore.InterfaceModule;
using MayaFurnitureStore.ProductModule;

namespace MayaFurnitureStore.MenuModule
{
   public class ProductDetails : IProduct
    {
        public ProductDetails()
        {
            Console.WriteLine("****Please the Products You Want to Purchase****");
            ProductBO productBO = new ProductBO();
            productBO.GetAllProducts();
        }

        void IProduct.ProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
