using System;
using FoodStoreMarket.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodStoreMarket.Persistance.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.OwnsOne(p => p.PersonName);
            builder.OwnsOne(p => p.Adres);


            builder.OwnsOne(c => c.PersonName).Property(pn => pn.FirstName).HasMaxLength(20).IsRequired();
            builder.OwnsOne(c => c.PersonName).Property(pn => pn.LastName).HasMaxLength(30).IsRequired();
            builder.OwnsOne(rs => rs.Adres).Property(a => a.City).HasMaxLength(255).IsRequired();
            builder.OwnsOne(rs => rs.Adres).Property(a => a.Street).HasMaxLength(255).IsRequired();
            builder.OwnsOne(rs => rs.Adres).Property(a => a.HouseNumber).HasMaxLength(255).IsRequired();
            builder.OwnsOne(rs => rs.Adres).Property(a => a.FlatNumber).HasMaxLength(255);
            builder.OwnsOne(rs => rs.Adres).Property(a => a.PostCode).HasMaxLength(6).IsRequired();
            builder.OwnsOne(rs => rs.Adres).Property(a => a.PhoneNumber).HasMaxLength(9).IsRequired();
            builder.OwnsOne(rs => rs.Adres).Property(a => a.Email).HasMaxLength(255).IsRequired();
        }
    }
}

