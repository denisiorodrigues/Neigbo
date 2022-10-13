using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Neigbo.API.Models.Entities;

namespace Neigbo.API.Database.Mappings
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(x => x.CreatedAt)
                .IsRequired()
                .HasColumnType("DateTIme");

            builder.Property(x => x.EditidAt)
                .IsRequired()
                .HasColumnType("DateTIme");

            builder.ToTable("Categories");
        }
    }
}