using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {


        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(300);
            builder.Property(p => p.Price).HasColumnType("decimal(18,2)");
            builder.Property(p => p.NetWeigh).HasColumnType("decimal(18,2)");

            builder.Property(p => p.PictureUrl).IsRequired();
            builder.HasOne(d => d.DietType).WithMany()
                .HasForeignKey(p => p.DietTypeId);
            builder.HasOne(t => t.ProductType).WithMany()
               .HasForeignKey(p => p.ProductTypeId);
        }
    }
}
