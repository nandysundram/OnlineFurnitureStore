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
    public class UserBO
    {
       public static List<User> usersList = new List<User>();


        // Create a new User
        public bool Admin(string AdminName,string AdminPassword)
        {
            string CorrectName = "Admin";
            string CorrectPass = "Admin@123";
            if (AdminName != CorrectName && AdminPassword != CorrectPass)
            {
                return false;
            }
            else
            {
               return true;
            }
           
        }
        public bool CreateNewUser(string uName, string email, long phone, int age, string password)
        {
            User user = FindUser(email);
            if(user == null)
            { 
                 user = new User(uName,email,phone,age,password);
                usersList.Add(user);
                return true;
            }
            else
            {
                return false;
            }

        }
        public List<User> GetAllUser()
        {
            if (usersList.Count == 0)
            {
                return null;
            }
            else
            {
                return usersList;
            }
        }
        public bool UpdateUser(long newPhone, string Email)
        {
            User user = FindUser(Email);

            if (user != null)
            {
                User temUer = user;
                user.Phone = newPhone;
                usersList.Remove(temUer);
                usersList.Add(user);
                return true;
            }
            else
            {
                return false;
            }
        }
      public bool  DeletetheUser(string Useremail)
        {
            User user = FindUser(Useremail);
            if(user != null)
            {
                usersList.Remove(user);
                return true;
            }
            else
            {
                return false;
            }
        }

        public User FindUser(string SearchEmail)
        {
            var user = (from k in usersList
                        where k.Email == SearchEmail
                        select k).FirstOrDefault();
            return user;
        }
        public bool Login(string CheckName, string CheckMail)
        {
            foreach (User user in usersList)
            {
                if (CheckName == user.UserName && CheckMail == user.Email)
                return true;
            }
            return false;


        }

    }
}
