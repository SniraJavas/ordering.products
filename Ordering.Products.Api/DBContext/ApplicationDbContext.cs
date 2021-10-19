using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ordering.products.api.IdentityAuth;
using ordering.products.api.Model;

namespace ordering.products.api.DBContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ 
        
        
        }

        public ApplicationDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public virtual DbSet<Product> Products { get; set;}
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<User> UsersInfo { set; get; }



    }
}
