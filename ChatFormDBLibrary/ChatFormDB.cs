using System.Collections.Generic;
using System.Linq;

namespace ChatFormDBLibrary
{
    public static class ChatFormDB
    {
        public static List<User> GetAllUsers()
        {
            using (var db=new ChatFormEntities())
            {
                return db.Users.ToList();
            }
        }
        public static List<Message> GetAllMessages()
        {
            using (var db = new ChatFormEntities())
            {
                return db.Messages.ToList();
            }
        }
        public static List<ViewForm> GetAllViewForms()
        {
            using (var db = new ChatFormEntities())
            {
                return db.ViewForms.ToList();
            }
        }
        public static string AddUser(User user)
        {
            using (var db = new ChatFormEntities())
            {
                try
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    return "User added";
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                {
                    return $"Error!!! {ex.Message}";
                }
            }
        }
        public static string AddMessage(Message message)
        {
            using (var db = new ChatFormEntities())
            {
                try
                {
                    db.Messages.Add(message);
                    db.SaveChanges();
                    return "Message added";
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                {
                    return $"Error!!! {ex.Message}";
                }
            }
        }
        public static string AddViewForm (ViewForm viewForm)
        {
            using (var db = new ChatFormEntities())
            {
                try
                {
                    db.ViewForms.Add(viewForm);
                    db.SaveChanges();
                    return "ViewForm added";
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                {
                    return $"Error!!! {ex.Message}";
                }
            }
        }
        public static string EditUser(User user)
        {
            using (var db = new ChatFormEntities())
            {
                try
                {
                    db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return "User edited";
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                {
                    return $"Error!!! {ex.Message}";
                }
            }
        }
        public static string EditMessage(Message message)
        {
            using (var db = new ChatFormEntities())
            {
                try
                {
                    db.Entry(message).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return "Message edited";
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                {
                    return $"Error!!! {ex.Message}";
                }
            }
        }
        public static string EditViewForm(ViewForm viewForm)
        {
            using (var db = new ChatFormEntities())
            {
                try
                {
                    db.Entry(viewForm).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return "ViewForm edited";
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                {
                    return $"Error!!! {ex.Message}";
                }
            }
        }
        public static string DeleteUser(User user)
        {
            using (var db = new ChatFormEntities())
            {
                db.Entry(user).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                return "User deleted";
            }
        }       
    }
}