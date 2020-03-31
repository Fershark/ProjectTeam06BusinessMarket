using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessMarketplaceEntitiesNS
{
    public class BusinessMarketplaceEntitiesContext: DbContext
    {

        public BusinessMarketplaceEntitiesContext(): base("name=BusinessMarketplaceConnection")
        {
        }

        public virtual DbSet<Business> Businesses { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Business>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Business)
                .HasForeignKey(e => e.BusinessId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Business>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Business)
                .HasForeignKey(e => e.BusinessId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.CategoryId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Products)
                .WithMany(e => e.Orders)
                .Map(po =>
                {
                    po.MapLeftKey("OrderId");
                    po.MapRightKey("ProductId");
                    po.ToTable("OrderProducts");
                });
        }
    }
}
