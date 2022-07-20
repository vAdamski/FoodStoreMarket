using System;

namespace FoodStoreMarket.Domain.Exceptions;

public class ObjectWithIdNotExistException : Exception
{
    public ObjectWithIdNotExistException(int id, string objectName = "Object") 
        : base($"{objectName} with Id = {id} not found in database", new Exception())
    {
        
    }
}