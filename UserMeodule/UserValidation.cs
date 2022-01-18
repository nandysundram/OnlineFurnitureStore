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
using System.Text.RegularExpressions;

namespace MayaFurnitureStore.UsersModules
{
    class UserValidation
    {
        string Password, Email;
        public string ValidatePassword(string Password)
        {
            Regex regex = new Regex(@"^(.{0,7}|[^0-9]*|[^A-Z])$");

            if (!regex.IsMatch(Password))
            {
                Console.WriteLine("Invalid Password Format");
                Console.WriteLine("Enter Valid Password");
                this.Password = Console.ReadLine();
                ValidatePassword(this.Password);
            }
            return this.Password;
        }

        public string ValidateEmail(string Email)
        {
            Regex regex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            if (!regex.IsMatch(Email))
            {
                Console.WriteLine("Invalid Email Address");
                Console.WriteLine("Enter valid mail address:");
                this.Email = Console.ReadLine();
                ValidateEmail(this.Email);
            }
            return this.Email;
        }
    }
}


    
