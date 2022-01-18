using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MayaFurnitureStore.MenuModule;
using MayaFurnitureStore.InterfaceModule;
using MayaFurniturestore.MenuModule;
using MayaFurnitureStore.ProductModule;


namespace MayaFurnitureStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            AdminMenu adminMenu = new AdminMenu();
            UserDetails userDetails = new UserDetails();
            Console.WriteLine("Enter your mode of viewing application:");
            Console.WriteLine("\n Press 1.For Admin Mode \n Press 2.For User Mode");
            do
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    adminMenu.DisplayMenu();
                }
                else if (choice == 2)
                {
                    userDetails.UserMenu();
                }
                else
                {
                    Console.WriteLine("Please enter a valid input!!!");
                }
            } while (true);
            



        }
    }
}
