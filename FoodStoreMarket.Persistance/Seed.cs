using System;
using FoodStoreMarket.Domain.Entities;
using FoodStoreMarket.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodStoreMarket.Persistance
{
    public static class Seed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>(r =>
            {
                r.HasData(new Restaurant()
                {
                    Id = 1,
                    StatusId = 1,
                    Created = DateTime.Now
                });
            });

            modelBuilder.Entity<RestaurantSpecification>(rs =>
            {
                rs.HasData(new RestaurantSpecification()
                {
                    Id = 1,
                    RestaurantId = 1,
                    StatusId = 1,
                    Created = DateTime.Now,
                    Name = "BestKebab",
                    Description = "Best Kebab in Lodz"
                });
                rs.OwnsOne(rs => rs.Adres).HasData(new
                {
                    RestaurantSpecificationId = 1,
                    City = "Lodz",
                    PostCode = "94-042",
                    Street = "Olimpijska",
                    HouseNumber = "16",
                    PhoneNumber = "123456789",
                    Email = "bestkebab@gmail.com"
                });
            });

            modelBuilder.Entity<Employee>(e =>
            {
                //First employee
                e.HasData(new Employee()
                {
                    Id = 1,
                    StatusId = 1,
                    Created = DateTime.Now,
                    RestaurantSpecificationId = 1
                });
                e.OwnsOne(e => e.PersonName).HasData(new
                {
                    EmployeeId = 1,
                    FirstName = "Mateusz",
                    LastName = "Nowak"
                });
                e.OwnsOne(e => e.Adres).HasData(new
                {
                    EmployeeId = 1,
                    City = "Lodz",
                    PostCode = "94-042",
                    Street = "Rajdowa",
                    HouseNumber = "10",
                    FlatNumber = "1",
                    PhoneNumber = "112233445",
                    Email = "mateusz.nowak@gmail.com"
                });

                //Secound emp
                e.HasData(new Employee()
                {
                    Id = 2,
                    StatusId = 1,
                    Created = DateTime.Now,
                    RestaurantSpecificationId = 1
                });
                e.OwnsOne(e => e.PersonName).HasData(new
                {
                    EmployeeId = 1,
                    FirstName = "Mariusz",
                    LastName = "Gruszka"
                });
                e.OwnsOne(e => e.Adres).HasData(new
                {
                    EmployeeId = 1,
                    City = "Lodz",
                    PostCode = "94-042",
                    Street = "Retkinska",
                    HouseNumber = "80",
                    FlatNumber = "44",
                    PhoneNumber = "987654321",
                    Email = "mariusz.gruszka@gmail.com"
                });
            });

            modelBuilder.Entity<OpeningClosingSpecification>(ocs =>
            {
                ocs.HasData(new OpeningClosingSpecification()
                {
                    Id = 1,
                    StatusId = 1,
                    Created = DateTime.Now,
                    RestaurantSpecificationId = 1
                });
            });

            modelBuilder.Entity<OpeningClosingHours>(och =>
            {
                //Monday
                och.HasData(new OpeningClosingHours()
                {
                    Id = 1,
                    StatusId = 1,
                    Created = DateTime.Now,
                    OpeningClosingSpecificationId = 1,
                    Day = "Monday",
                });
                och.OwnsOne(och => och.OpeningTime).HasData(new
                {
                    OpeningClosingHoursId = 1,
                    Hour = 8,
                    Minute = 0,
                    Secound = 0
                });
                och.OwnsOne(och => och.ClosingTime).HasData(new
                {
                    OpeningClosingHoursId = 1,
                    Hour = 8,
                    Minute = 0,
                    Secound = 0
                });

                //Tuesday
                och.HasData(new OpeningClosingHours()
                {
                    Id = 2,
                    StatusId = 1,
                    Created = DateTime.Now,
                    OpeningClosingSpecificationId = 1,
                    Day = "Tuesday",
                });
                och.OwnsOne(och => och.OpeningTime).HasData(new
                {
                    OpeningClosingHoursId = 2,
                    Hour = 8,
                    Minute = 0,
                    Secound = 0
                });
                och.OwnsOne(och => och.ClosingTime).HasData(new
                {
                    OpeningClosingHoursId = 2,
                    Hour = 8,
                    Minute = 0,
                    Secound = 0
                });

                //Wednesday
                och.HasData(new OpeningClosingHours()
                {
                    Id = 3,
                    StatusId = 1,
                    Created = DateTime.Now,
                    OpeningClosingSpecificationId = 1,
                    Day = "Wednesday",
                });
                och.OwnsOne(och => och.OpeningTime).HasData(new
                {
                    OpeningClosingHoursId = 3,
                    Hour = 8,
                    Minute = 0,
                    Secound = 0
                });
                och.OwnsOne(och => och.ClosingTime).HasData(new
                {
                    OpeningClosingHoursId = 3,
                    Hour = 8,
                    Minute = 0,
                    Secound = 0
                });

                //Thursday
                och.HasData(new OpeningClosingHours()
                {
                    Id = 4,
                    StatusId = 1,
                    Created = DateTime.Now,
                    OpeningClosingSpecificationId = 1,
                    Day = "Thursday",
                });
                och.OwnsOne(och => och.OpeningTime).HasData(new
                {
                    OpeningClosingHoursId = 4,
                    Hour = 8,
                    Minute = 0,
                    Secound = 0
                });
                och.OwnsOne(och => och.ClosingTime).HasData(new
                {
                    OpeningClosingHoursId = 4,
                    Hour = 8,
                    Minute = 0,
                    Secound = 0
                });

                //Friday
                och.HasData(new OpeningClosingHours()
                {
                    Id = 5,
                    StatusId = 1,
                    Created = DateTime.Now,
                    OpeningClosingSpecificationId = 1,
                    Day = "Thursday",
                });
                och.OwnsOne(och => och.OpeningTime).HasData(new
                {
                    OpeningClosingHoursId = 5,
                    Hour = 8,
                    Minute = 0,
                    Secound = 0
                });
                och.OwnsOne(och => och.ClosingTime).HasData(new
                {
                    OpeningClosingHoursId = 5,
                    Hour = 8,
                    Minute = 0,
                    Secound = 0
                });


            });
        }
    }
}

