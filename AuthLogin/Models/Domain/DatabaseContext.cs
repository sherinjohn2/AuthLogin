//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using AuthLogin.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace AuthLogin.Models.DTO
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {

        }

        public DbSet<LoginModel> LoginModel { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<LoginModel>(entity => {
                entity.HasKey(k => k.userId);
            });
        }
    }

}
