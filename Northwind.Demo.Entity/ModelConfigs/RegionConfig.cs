using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Demo.Entity.Models;

namespace Northwind.Demo.Entity.ModelConfigs
{
    public class RegionConfig : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> entity)
        {

            entity.HasKey(e => e.RegionId).HasName("pk_region");

            entity.ToTable("region");

            entity.Property(e => e.RegionId)
                .ValueGeneratedNever()
                .HasColumnName("region_id");

            entity.Property(e => e.RegionDescription)
                .HasMaxLength(60)
                .HasColumnName("region_description")
                .IsRequired();
        }
    }
}
