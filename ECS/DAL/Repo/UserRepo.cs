using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRepo
    {
        static ECSEntities context;
        static UserRepo()
        {
            context = new ECSEntities();
        }

        // Return UserType
        public static string GetUserType(int id)
        {
                var result = (from u in context.Users
                              join c in context.Credentials on u.Id equals c.UserId
                              where c.UserId == id
                              select c.UserType).FirstOrDefault();
            return result;
        }

        //Get All the Users
        public static List<User> GetAllUsers()
        {
            List<User> users = context.Users.ToList();
            return users;
        }

        //Update user
        public static void UpdateUser(User u)
        {
            var user = context.Users.FirstOrDefault(x =>x.Id  == u.Id);
            context.Entry(user).CurrentValues.SetValues(u);
            context.SaveChanges();
        }

        // Return UserType
        public static User GetUser(int id)
        {
            var result = context.Users.Where(x => x.Id == id).FirstOrDefault();
            return result;
        }

        //Get All the Admins===========================================
        public static  List<User> GetAllAdmins()
        {
            string role = "Admin";
            List<User> admins = (from u in context.Users
                                join c in context.Credentials on u.Id equals c.UserId
                                where c.UserType == role
                                select u).ToList();

            return admins;
        }

        //Add admin
        public static void AddAdmin(User u,Credential c)
        {
            u.RegDate = DateTime.Now;
            context.Users.Add(u);
            context.SaveChanges();
            c.UserId = u.Id;
            context.Credentials.Add(c);
            context.SaveChanges();
        }

        //Get All the Buyers============================================
        public static List<User> GetAllBuyers()
        {
            string role = "Buyer";
            List<User> data = (from u in context.Users
                                 join c in context.Credentials on u.Id equals c.UserId
                                 where c.UserType == role
                                 select u).ToList();

            return data;
        }

        //Get All the Sellers===========================================
        public static List<User> GetAllSellers()
        {
            string role = "Seller";
            List<User> data = (from u in context.Users
                                join c in context.Credentials on u.Id equals c.UserId
                                where c.UserType == role
                                select u).ToList();

            return data;
        }
    }
}
