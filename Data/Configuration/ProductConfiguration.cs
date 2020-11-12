using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);//primary keydir

            builder.Property(x=>x.Id).UseIdentityColumn();//id identitydir artan index

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);//boş geçilemez 200  karakter uzunluk

            builder.Property(x => x.Stock).IsRequired();

            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");//tipverme

            builder.Property(x => x.InnerBarcode).HasMaxLength(50);

        }
    }
}
