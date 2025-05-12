using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Demo.Repository.Models;

namespace Northwind.Demo.Repository.ModelConfigs
{
    public class OrderDetailConfig : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {

            builder.ToTable("order_details");
            builder.HasKey(e => new { e.OrderId, e.ProductId }).HasName("pk_order_details");

            builder.Property(e => e.OrderId).HasColumnName("order_id").IsRequired();

            builder.Property(e => e.ProductId).HasColumnName("product_id");
            builder.Property(e => e.Discount).HasColumnName("discount");
            builder.Property(e => e.Quantity).HasColumnName("quantity");
            builder.Property(e => e.UnitPrice).HasColumnName("unit_price");

            builder.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_order_details_orders");

            builder.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_order_details_products");

        }
    }
}
