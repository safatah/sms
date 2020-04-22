using Microsoft.EntityFrameworkCore;
using HappyHelper.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace HappyHelper.Data
{
    public class HappyHelperContext : IdentityDbContext<SignUp>
    {
        public HappyHelperContext(DbContextOptions<HappyHelperContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<InventoryTracker>()
                .HasOne<SignUp>()
                .WithMany()
                .HasForeignKey(i => i.UserId);
        }

        //public DbSet<BusinessInfo> BusinessInfo { get; set; }
        //public DbSet<UserInfo> SignUp { get; set; }
        public DbSet<InventoryTracker> InventoryTracker { get; set; }
    }
}