using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Demo.Repository.Models;

namespace Northwind.Demo.Repository.ModelConfigs
{
    public class ShipperConfig : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.ToTable("shippers");

            builder.HasKey(e => e.ShipperId).HasName("pk_shippers");

            builder.Property(e => e.ShipperId)
                    .ValueGeneratedNever()
                    .HasColumnName("shipper_id");

            builder.Property(e => e.CompanyName)
                    .HasMaxLength(40)
                    .HasColumnName("company_name")
                    .IsRequired();

            builder.Property(e => e.Phone)
                    .HasMaxLength(24)
                    .HasColumnName("phone");
        }
    }
}
