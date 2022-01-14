using System;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodStoreMarket.Persistance.Configuration
{
    public class RestaurantSpecificationConfiguration : IEntityTypeConfiguration<RestaurantSpecification>
    {
        public void Configure(EntityTypeBuilder<RestaurantSpecification> builder)
        {
            builder.OwnsOne(p => p.Adres);

            builder
                .HasOne(rs => rs.Restaurant)
                .WithOne(r => r.RestaurantSpecification)
                .HasForeignKey<Restaurant>(r => r.RestaurantSpecificationId)
                .IsRequired();

            builder
                .HasOne(rs => rs.OpeningClosingSpecification)
                .WithOne(ocs => ocs.RestaurantSpecification)
                .HasForeignKey<OpeningClosingSpecification>(ocs => ocs.RestaurantSpecificationId)
                .IsRequired(false);

            builder.Property(rs => rs.Name).HasMaxLength(255).IsRequired();
            builder.OwnsOne(rs => rs.Adres).Property(a => a.City).HasMaxLength(255).IsRequired();
            builder.OwnsOne(rs => rs.Adres).Property(a => a.Street).HasMaxLength(255).IsRequired();
            builder.OwnsOne(rs => rs.Adres).Property(a => a.HouseNumber).HasMaxLength(255).IsRequired();
            builder.OwnsOne(rs => rs.Adres).Property(a => a.PostCode).HasMaxLength(6).IsRequired();
            builder.OwnsOne(rs => rs.Adres).Property(a => a.PhoneNumber).HasMaxLength(9).IsRequired();
            builder.OwnsOne(rs => rs.Adres).Property(a => a.Email).HasMaxLength(255).IsRequired();
        }
    }
}

