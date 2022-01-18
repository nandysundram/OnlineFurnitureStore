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
using MayaFurnitureStore.InterfaceModule;
using MayaFurnitureStore.UsersModules;

namespace MayaFurnitureStore.MenuModule
{
    public class AdminMenu : IMenu
    {
        public void DisplayMenu()
        {
            Console.Write("*******Welcome Admin to MayaFurnitureStore******");
            UserBO userBO = new UserBO();
            UserValidation userValidation = new UserValidation();
            Console.WriteLine("\nEnter your Admin Username:");
            string AdminName = Console.ReadLine();
            Console.WriteLine("\nenter your Admin Password");
            string Adminpassword = Console.ReadLine();
            bool Success = userBO.Admin(AdminName, Adminpassword);
            if (Success)
            {
                Console.WriteLine("ADMIN LOGIN SUCCESSFULL!!!");
                Console.WriteLine("\n********ADMIN OPERATIONS******");
                Console.WriteLine("Select the Any Options");
                Console.WriteLine("1.Add User 2. Update User 3. Delete User 4. Display All users");
                int UserInput = Convert.ToInt32(Console.ReadLine());

                // Create Instance user Bo Class to Access Funalities 

                switch (UserInput)
                {
                    case 1:
                        Console.WriteLine("*****ENTER THE USER_DETAILS*****");
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
                        { Console.WriteLine("user Not Added SuccessFully"); }
                        break;
                    case 2:
                        Console.WriteLine("enter the phone number you want to update:");
                        long newPhone = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("enter the email you want to update:");
                        string Email = Console.ReadLine();
                        bool result = userBO.UpdateUser(newPhone, Email);
                        if (result) { Console.WriteLine("Number and email updated succesfully!!!!"); }
                        break;
                    case 3:
                        Console.WriteLine("enter the email of the user you want to delete:");
                        string Useremail = Console.ReadLine();
                        bool Del = userBO.DeletetheUser(Useremail);
                        if (Del) { Console.WriteLine("user deleted succesfully!!!"); }
                        else { Console.WriteLine("in appropiate action"); }
                        break;
                    case 4:
                        List<User> usersList = userBO.GetAllUser();
                        Console.WriteLine("UserName{0}, Email, Phone, Age");
                        foreach (var item in usersList)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    default:
                        break;

                }

            }
            else
            {
                Console.WriteLine("Invalid Username and password");
                userBO.Admin(AdminName, Adminpassword);
            }
        }
    }
}
