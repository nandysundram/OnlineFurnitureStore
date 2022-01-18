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

namespace MayaFurnitureStore.UsersModules
{
    // User Class to collect its Behavour and Properties
    public class User
    {
        // User Fields
        string userName;
        string email;
        long phone;
        int age;
        string password;

        // Zero Parameterised Con
        public User()
        {
        }
        // Parameterised Contr

        public User( string uName, string email, long phone, int age, string password)
        {

            UserName= uName;
            Email = email;
            Phone = phone;
            Age = age;
            Password = password;
        }


        // Properties
        public string UserName { get => userName; set => userName = value; }
        public string Email { get => email; set => email = value; }
        public long Phone { get => phone; set => phone = value; }
        public int Age { get => age; set => age = value; }
        public string Password { get => password; set => password = value; }

        // Compar to objcts based on Eqauls
        public override bool Equals(object obj)
        {
            User tempUser= obj as User;
            User user = this;
            return user.Email.Equals(tempUser.Email);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        // Convert to Object
        public override string ToString()
        {
            return String.Format("{0,20} {1,20} {2,15} {3,10}", UserName, Email, Phone, Age);
        }



    }
}
