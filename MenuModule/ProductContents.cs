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
using MayaFurniturestore.MenuModule;
using MayaFurnitureStore.InterfaceModule;
using MayaFurnitureStore.ProductModule;

namespace MayaFurnitureStore.MenuModule
{
    public class ProductContents : IProduct
    {
        public void ProductDetails()
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

