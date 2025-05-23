using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Demo.Entity.Models;

namespace Northwind.Demo.Entity.ModelConfigs
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("categories");

            builder.HasKey(e => e.CategoryId).HasName("pk_categories");

            builder.Property(e => e.CategoryId)
                .ValueGeneratedNever()
                .HasColumnName("category_id")
                .IsRequired();

            builder.Property(e => e.CategoryName)
                .HasMaxLength(15)
                .HasColumnName("category_name")
                .IsRequired();

            builder.Property(e => e.Description).HasColumnName("description");

            builder.Property(e => e.Picture).HasColumnName("picture");

        }
    }
}
