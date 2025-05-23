using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Demo.Entity.Models;

namespace Northwind.Demo.Entity.ModelConfigs
{
    public class CustomerDemographicConfig : IEntityTypeConfiguration<CustomerDemographic>
    {
        public void Configure(EntityTypeBuilder<CustomerDemographic> entity)
        {
            entity.HasKey(e => e.CustomerTypeId).HasName("pk_customer_demographics");

            entity.ToTable("customer_demographics");

            entity.Property(e => e.CustomerTypeId)
                .HasMaxLength(5)
                .HasColumnName("customer_type_id");
            entity.Property(e => e.CustomerDesc).HasColumnName("customer_desc");
        }
    }
}
