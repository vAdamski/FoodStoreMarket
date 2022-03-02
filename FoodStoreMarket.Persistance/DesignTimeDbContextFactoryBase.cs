﻿using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FoodStoreMarket.Persistance
{
    public abstract class DesignTimeDbContextFactoryBase<TContext> : IDesignTimeDbContextFactory<TContext> where TContext : DbContext
    {
        private const string ConnectionString = "FoodStoreMarketDatabase";
        private const string AspNetCoreEnvironment = "ASPNETCORE_ENVIRONMENT";

        public TContext CreateDbContext(string[] args)
        {
            var basePath = Directory.GetCurrentDirectory() + String.Format("{0}..{0}FoodStoreMarket", Path.DirectorySeparatorChar);
            return Create(basePath, Environment.GetEnvironmentVariable(AspNetCoreEnvironment));
        }

        protected abstract TContext CreateNewInstance(DbContextOptions<TContext> options);

        private TContext Create(string basePath, string enviromentName)
        {
            var configuration = new ConfigurationBuilder().
                SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.Local.json", optional: true)
                .AddJsonFile($"appsettings.{enviromentName}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            var connectionString = configuration.GetConnectionString(ConnectionString);

            return Create(connectionString);
        }

        private TContext Create(string connectionString)
        {
            if(string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException($"Connection string '{connectionString}' is null or empty.", nameof(connectionString));
            }

            Console.WriteLine($"DesignTimeDbContextFactoryBase.Create(string): Connection string: '{connectionString}'.");

            var optionBuilder = new DbContextOptionsBuilder<TContext>();

            optionBuilder.UseSqlServer(connectionString);

            return CreateNewInstance(optionBuilder.Options);
        }
    }
}

