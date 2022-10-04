using System;
using System.Runtime.InteropServices;

namespace FoodStoreMarket.Persistance;

public static class ConnectionStringDbContext
{
    public static string GetConnectionStringByPlatform()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return "FoodStoreMarketDatabasePC";
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) return "FoodStoreMarketDatabase";
        else throw new Exception("Connection string is not implemented for this platform!");
    }
}