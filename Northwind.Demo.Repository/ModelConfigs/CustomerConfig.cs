using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Demo.Repository.Models;

namespace Northwind.Demo.Repository.ModelConfigs
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> entity)
        {

            entity.HasKey(e => e.CustomerId).HasName("pk_customers");

            entity.ToTable("customers");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(5)
                .HasColumnName("customer_id");
            entity.Property(e => e.Address)
                .HasMaxLength(60)
                .HasColumnName("address");
            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(40)
                .HasColumnName("company_name")
                .IsRequired();

            entity.Property(e => e.ContactName)
                .HasMaxLength(30)
                .HasColumnName("contact_name");
            entity.Property(e => e.ContactTitle)
                .HasMaxLength(30)
                .HasColumnName("contact_title");
            entity.Property(e => e.Country)
                .HasMaxLength(15)
                .HasColumnName("country");
            entity.Property(e => e.Fax)
                .HasMaxLength(24)
                .HasColumnName("fax");
            entity.Property(e => e.Phone)
                .HasMaxLength(24)
                .HasColumnName("phone");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(10)
                .HasColumnName("postal_code");
            entity.Property(e => e.Region)
                .HasMaxLength(15)
                .HasColumnName("region");

            //entity.HasMany(d => d.CustomerTypes).WithMany(p => p.Customers)
            //    .UsingEntity<Dictionary<string, object>>(
            //        "CustomerCustomerDemo",
            //        r => r.HasOne<CustomerDemographic>().WithMany()
            //            .HasForeignKey("CustomerTypeId")
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_customer_customer_demo_customer_demographics"),
            //        l => l.HasOne<Customer>().WithMany()
            //            .HasForeignKey("CustomerId")
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("fk_customer_customer_demo_customers"),
            //        j =>
            //        {
            //            j.HasKey("CustomerId", "CustomerTypeId").HasName("pk_customer_customer_demo");
            //            j.ToTable("customer_customer_demo");
            //            j.IndexerProperty<string>("CustomerId")
            //                .HasMaxLength(5)
            //                .HasColumnName("customer_id");
            //            j.IndexerProperty<string>("CustomerTypeId")
            //                .HasMaxLength(5)
            //                .HasColumnName("customer_type_id");
            //        });
        }
    }
}
