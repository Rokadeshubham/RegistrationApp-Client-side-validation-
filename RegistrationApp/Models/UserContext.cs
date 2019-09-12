using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RegistrationApp.Models;
using System.Data.Entity;

namespace RegistrationApp.Models
{
   public class UserContext:DbContext
    {
        public UserContext():base("UserContext"){
            Database.SetInitializer<UserContext>(new CreateDatabaseIfNotExists<UserContext>());
            }
        public DbSet<User> User { get; set; }
    }
}