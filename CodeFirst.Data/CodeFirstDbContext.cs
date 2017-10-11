using CodeFirst.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Data
{
    public class CodeFirstDbContext : DbContext
    {
        public CodeFirstDbContext()
            : base("DefaultConnection")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Roles)
                .WithMany(r => r.Users)
                .Map(m =>
                {
                    m.ToTable("RoleMemberships");
                    m.MapLeftKey("UserId");
                    m.MapRightKey("RoleId");
                });
            base.OnModelCreating(modelBuilder);
        }
    }

    public class CodeFirstContextInitializer : DropCreateDatabaseIfModelChanges<CodeFirstDbContext>
    {
        protected override void Seed(CodeFirstDbContext context)
        {
            var roles = new List<Role> { 
                new Role{ Name="超级管理员"},
                new Role{Name="一般管理员"}
            };
            roles.ForEach(m => context.Roles.Add(m));
            // base.Seed(context);
        }
    }
}
