/*
 * Application : online furniture Store
 * AuthorName: Nandhini sundram
 * Reviewed by :
 * Created on : 
 * Updated on : 12-Jan-2022
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
using MayaFurnitureStore.InterfaceModule;
using MayaFurnitureStore.UsersModules;
using System.Threading.Tasks;
using MayaFurnitureStore.ProductModule;
using MayaFurnitureStore.MenuModule;

namespace MayaFurniturestore.MenuModule
{
    class UserDetails: UserMenu
    {
        public void UserMenu()
        {
            Console.Write("Welcome User");
            Console.WriteLine("Select the Any Options");
            Console.WriteLine("1.Register 2. Login 3.Search an user 4. Display All users");
            int UserInput = 0;
            UserInput = Convert.ToInt32(Console.ReadLine());

            // Create Instance user Bo Class to Access Funalities 
            UserBO userBO = new UserBO();
            UserValidation userValidation = new UserValidation();
            ProductBO productBO = new ProductBO();
            ProductContents productDetails = new ProductContents();
            switch (UserInput)
            {
                case 1:
                    Console.WriteLine("Enter the User Details");
                    Console.WriteLine("Enter the User name");
                    string uName = Console.ReadLine();
                    Console.WriteLine("Enter the User email");
                    string email = Console.ReadLine();
                    userValidation.ValidateEmail(email);
                    Console.WriteLine("Enter the User phone");
                    long phone = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter the User age");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the User password");
                    string password = Console.ReadLine();
                    userValidation.ValidatePassword(password);
                    bool res = userBO.CreateNewUser(uName, email, phone, age, password);
                    if (res) { Console.WriteLine(" user Added SuccessFully"); }
                    else
                    {
                        Console.WriteLine(" user Not Added SuccessFully");
                    }

                    break;
                case 2:
                    Console.WriteLine("Enter the User name");
                    string ChekName = Console.ReadLine();
                    Console.WriteLine("Enter the User email");
                    string CheckEmail = Console.ReadLine();
                    bool value = userBO.Login(ChekName, CheckEmail);
                    if (value)
                    {
                        Console.WriteLine("Succesfully Loginned!!");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid name and password");
                    }
                    productDetails.ProductDetails();
                    break;
                case 3:
                    Console.WriteLine("enter the email you want to search:");
                    string SearchEmail = Console.ReadLine();
                    var search =userBO.FindUser(SearchEmail);
                    Console.WriteLine(search);
                    break;
                case 4:
                    List<User> users = userBO.GetAllUser();
                    Console.WriteLine("UserName, Email, Phone, Age");
                    foreach (var item in users)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                default:
                    break;

            }
            Console.WriteLine("*****Welcome User , Here we go with the ProductsList********");
            List<Product> Products = productBO.GetAllProducts();
            Console.WriteLine("Name,price,Id");
            foreach (var item in Products)
            {
                Console.WriteLine(item);
            }
        }
    }
}
     
