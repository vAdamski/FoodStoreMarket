using System;
using System.Collections.Generic;
using FoodStoreMarket.Domain.Common;

namespace FoodStoreMarket.Domain.ValueObjects
{
    public class Adres : ValueObject
    {
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string FlatNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }


        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return City;
            yield return PostCode;
            yield return Street;
            yield return HouseNumber;
            yield return FlatNumber;
            yield return PhoneNumber;
            yield return Email;
        }
    }
}

