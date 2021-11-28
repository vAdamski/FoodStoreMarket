using System;
using System.Collections.Generic;
using FoodStoreMarket.Domain.Common;

namespace FoodStoreMarket.Domain.ValueObjects
{
    public class Time : ValueObject
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Secound { get; set; }

        public override string ToString()
        {
            return $"{Hour}:{Minute}:{Secound}";
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Hour;
            yield return Minute;
            yield return Secound;
        }
    }
}

