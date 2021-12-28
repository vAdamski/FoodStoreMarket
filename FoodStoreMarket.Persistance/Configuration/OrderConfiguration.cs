using System;
using FoodStoreMarket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodStoreMarket.Persistance.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.OwnsOne(p => p.Adres);

            //builder.OwnsOne(rs => rs.Adres).Property(a => a.City).HasMaxLength(255).IsRequired();
            //builder.OwnsOne(rs => rs.Adres).Property(a => a.Street).HasMaxLength(255).IsRequired();
            //builder.OwnsOne(rs => rs.Adres).Property(a => a.HouseNumber).HasMaxLength(255).IsRequired();
            //builder.OwnsOne(rs => rs.Adres).Property(a => a.FlatNumber).HasMaxLength(255);
            //builder.OwnsOne(rs => rs.Adres).Property(a => a.PostCode).HasMaxLength(6).IsRequired();
            //builder.OwnsOne(rs => rs.Adres).Property(a => a.PhoneNumber).HasMaxLength(9).IsRequired();
            //builder.OwnsOne(rs => rs.Adres).Property(a => a.Email).HasMaxLength(255).IsRequired();
            //builder.Property(p => p.DateOfCreate).IsRequired();
        }
    }
}

