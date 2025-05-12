using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Demo.Repository.Models;

namespace Northwind.Demo.Repository.ModelConfigs
{
    public class EmployeeTerritoryConfig : IEntityTypeConfiguration<EmployeeTerritory>
    {
        public void Configure(EntityTypeBuilder<EmployeeTerritory> builder)
        {
            builder.ToTable("employee_territories");

            builder.HasKey(a => new { a.EmployeeId, a.TerritoryId }).HasName("pk_employee_territories");

            builder.Property(b => b.EmployeeId)
                .HasColumnName("employee_id");

            builder.Property(b => b.TerritoryId)
                .HasColumnType("varchar(20)")
                .HasColumnName("territory_id");

            builder.HasOne(d => d.Employees).WithMany()
                .HasForeignKey("EmployeeId")
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_employee_territories_employees");

            builder.HasOne(d => d.Territories).WithMany()
                .HasForeignKey("TerritoryId")
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_employee_territories_territories");
        }
    }
}
