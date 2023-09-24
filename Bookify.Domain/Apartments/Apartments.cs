using Bookify.Domain.Abstractions;
using Bookify.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Apartments
{
    public sealed class Apartments : Entity<ApartmentId>
    {
        public Apartments(
            ApartmentId id,
            Name name,
            Description description,
            Address address, 
            Money price,
            Money cleaningFee,
            List<Amenity> amenities
            ) : base(id) 
        {
            Name = name;
            Description = description;
            Address = address;
            Price = price;
            CleaningFee = cleaningFee;
            Amenities = amenities;
        }
        public Guid Id { get; private set; }
        public Name Name { get; private set; }
        public Description  Description { get; private set; }
        public Address Address { get; private set; }
        public Money Price { get; }
        public Money CleaningFee { get; }
        public Money PriceAmount { get; private set; }
        public Money PriceCurrency { get; private set; }
        public Money CleaningFeeAmount { get; private set; }
        public DateTime? LastBooked { get; private set; }
        public List<Amenity> Amenities { get; private set; } = new();


    }
}
  