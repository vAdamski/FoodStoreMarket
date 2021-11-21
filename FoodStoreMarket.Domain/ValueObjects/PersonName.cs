using System;
using System.Collections.Generic;
using FoodStoreMarket.Domain.Common;

namespace FoodStoreMarket.Domain.ValueObjects
{
    public class PersonName : ValueObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return FirstName;
            yield return LastName;
        }
    }
}

