using System;

namespace FoodStoreMarket.Domain.Exceptions;

public class InvalidRequestException: Exception
{
    public InvalidRequestException(Type objectType,string propertyName) 
        : base($"{objectType.ToString()} found problem with {propertyName}", new Exception())
    {
        
    }
}