using System;

namespace FoodStoreMarket.Domain.Exceptions;

public class ObjectNotExistInDbException : Exception
{
    public ObjectNotExistInDbException(int id, string objectName = "Object") 
        : base($"{objectName} with Id = {id} not found in database", new Exception())
    {
        
    }
}