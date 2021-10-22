using Eureka.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eureka.Infra.Data.Mapping
{
    public class CrudConfiguration : IEntityTypeConfiguration<Crud>
    {
        public void Configure(EntityTypeBuilder<Crud> builder)
        {
            builder.ToTable("crud");

            builder.HasKey(k => k.Id);

            builder.Property(t => t.Id)
                    .HasColumnName("id");

            builder.Property(t => t.Email)
                    .HasColumnType("varchar(150)")
                    .IsRequired()
                    .HasColumnName("email");

            builder.Property(t => t.Value)
                    .HasColumnType("decimal(10,2)")
                    .IsRequired()
                    .HasColumnName("value");

        }

    }
}
