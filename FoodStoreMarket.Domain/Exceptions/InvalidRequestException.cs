using System;

namespace FoodStoreMarket.Domain.Exceptions;

public class InvalidRequestException: Exception
{
    public InvalidRequestException(Type objectType,string propertyName, string description = "") 
        : base($"Found problem with {objectType.ToString()} {propertyName}. Info = {description}", new Exception())
    {
        
    }
}