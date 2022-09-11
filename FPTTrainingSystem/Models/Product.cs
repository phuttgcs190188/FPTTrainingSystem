using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Spatial;


namespace FPTTrainingSystem.Models
{
   
        [Table("ProductMaster")]
        public partial class Product
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public int ProductId { get; set; }

            [Required]
            [StringLength(50)]
            public string ProductName { get; set; }
            public string Image { get; set; }
        

            public double Price { get; set; }
        }
        public class ProductDbContext : DbContext
        {
            public ProductDbContext()
                : base("DefaultConnnection")
            {
            }
            public static ProductDbContext Create()
            {
                return new ProductDbContext();
            }
            public DbSet<Product> ProductMaster { get; set; }
        }

    }
   
    

