using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace DemoLearningApplication.Models.Context
{
    public class User : IdentityUser
    {

    }

    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<UserDetails> userDetails { get; set; }
    }
}