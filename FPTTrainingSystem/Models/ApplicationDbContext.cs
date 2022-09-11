﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FPTTrainingSystem.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<FPTTrainingSystem.Models.Post> Posts { get; set; }
        public System.Data.Entity.DbSet<FPTTrainingSystem.Models.Course> Courses { get; set; }

        public System.Data.Entity.DbSet<FPTTrainingSystem.Models.CheckOut> CheckOuts { get; set; }

        public System.Data.Entity.DbSet<FPTTrainingSystem.Models.Product> Products { get; set; }



        //public System.Data.Entity.DbSet<MVCBlog.Models.ApplicationUser> ApplicationUsers { get; set; }
    }
}