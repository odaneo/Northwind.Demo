using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Demo.Repository.Models;

namespace Northwind.Demo.Repository.ModelConfigs
{
    public class UsStateConfig : IEntityTypeConfiguration<UsState>
    {
        public void Configure(EntityTypeBuilder<UsState> entity)
        {

            entity.HasKey(e => e.StateId).HasName("pk_usstates");

            entity.ToTable("us_states");

            entity.Property(e => e.StateId)
                .ValueGeneratedNever()
                .HasColumnName("state_id");
            entity.Property(e => e.StateAbbr)
                .HasMaxLength(2)
                .HasColumnName("state_abbr");
            entity.Property(e => e.StateName)
                .HasMaxLength(100)
                .HasColumnName("state_name");
            entity.Property(e => e.StateRegion)
                .HasMaxLength(50)
                .HasColumnName("state_region");
        }
    }
}
