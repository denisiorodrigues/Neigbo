using Microsoft.EntityFrameworkCore;
using Neigbo.API.Models.Entities;

namespace Neigbo.API.Models
{
    public class AppContext : DbContext
    {
        protected AppContext(DbContextOptions<AppContext> options) 
            : base(options) { }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            //Atualizar a data de criação e update aqui

            base.OnModelCreating(modelBuilder);
        }
    }
}