using Microsoft.EntityFrameworkCore;
using HappyHelper.Models;

namespace HappyHelper.Data
{
    public class HappyHelperContext : DbContext
    {
        public HappyHelperContext(DbContextOptions<HappyHelperContext> options)
            : base(options)
        {
        }

        public DbSet<SignUp> SignUp { get; set; }
    }
}