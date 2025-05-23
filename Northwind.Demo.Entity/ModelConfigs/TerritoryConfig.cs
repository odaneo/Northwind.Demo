using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Demo.Entity.Models;

namespace Northwind.Demo.Entity.ModelConfigs
{
    public class TerritoryConfig : IEntityTypeConfiguration<Territory>
    {
        public void Configure(EntityTypeBuilder<Territory> entity)
        {

            entity.HasKey(e => e.TerritoryId).HasName("pk_territories");

            entity.ToTable("territories");

            entity.Property(e => e.TerritoryId)
                .HasMaxLength(20)
                .HasColumnName("territory_id");

            entity.Property(e => e.RegionId)
                .HasColumnName("region_id")
                .IsRequired();

            entity.Property(e => e.TerritoryDescription)
                .HasMaxLength(60)
                .HasColumnName("territory_description")
                .IsRequired();

            entity.HasOne(d => d.Region).WithMany(p => p.Territories)
                .HasForeignKey(d => d.RegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_territories_region");
        }
    }
}
