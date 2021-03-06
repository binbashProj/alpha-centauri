namespace binbash.Models {

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    public partial class BinBashModelsContext : DbContext {

        public BinBashModelsContext()
            : base("name=BinBashModelsConnection") {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Category>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Description)
                .IsUnicode(false);
        }
    }

    public partial class Category {

        public Category() {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        [DataType(DataType.MultilineText)]
        [Required]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }

    public partial class Product {

        public Product() {
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        [DataType(DataType.MultilineText)]
        [Required]
        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = false)]
        public double Price { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public string ImageURL { get; set; }
        [NotMapped]
        public int Quantity { get; set; }
    }

    public partial class AspNetUser {
        public string Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        public Boolean IsAdmin { get; private set; }
    }

    public partial class CartItem {
        public int Quantity { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public double ItemTotal { get; set; }
    }
}
