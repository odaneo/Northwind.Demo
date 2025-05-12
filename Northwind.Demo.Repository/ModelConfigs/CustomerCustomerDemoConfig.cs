using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Demo.Repository.Models;

namespace Northwind.Demo.Repository.ModelConfigs
{
    public class CustomerCustomerDemoConfig : IEntityTypeConfiguration<CustomerCustomerDemo>
    {
        public void Configure(EntityTypeBuilder<CustomerCustomerDemo> builder)
        {
            builder.HasKey(e => new { e.CustomerId, e.CustomerTypeId }).HasName("pk_customer_customer_demo");

            builder.ToTable("customer_customer_demo");

            builder.Property(e => e.CustomerId)
                .HasMaxLength(5)
                .HasColumnName("customer_id")
                .IsRequired();

            builder.Property(e => e.CustomerTypeId)
                .HasMaxLength(5)
                .HasColumnName("customer_type_id")
                .IsRequired();

            builder.HasOne(d => d.Customers)
                .WithMany()
                .HasForeignKey("CustomerId")
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_customer_customer_demo_customers");

            builder.HasOne(d => d.CustomerTypes)
                .WithMany()
                .HasForeignKey("CustomerTypeId")
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_customer_customer_demo_customer_demographics");
        }
    }
}
