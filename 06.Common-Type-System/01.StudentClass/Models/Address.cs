namespace StudentClass.Models
{
    using System;

    using AddressEnumerations;
    using Contracts;

    public class Address : IAddress, ICloneable
    {
        public Address(CityType city, NeighbourhoodType neighbourhood)
        {
            this.City = city;
            this.Neighbourhood = neighbourhood;
        }

        public CityType City { get; set; }

        public NeighbourhoodType Neighbourhood { get; set; }

        public override string ToString()
        {
            return $"Town: {this.City}, Neighbourhood: {this.Neighbourhood}";
        }

        public override bool Equals(object obj)
        {
            var otherAddress = obj as Address;
            if (this.City != otherAddress.City)
            {
                return false;
            }
            if (this.Neighbourhood != otherAddress.Neighbourhood)
            {
                return false;
            }

            return true;
        }

        public object Clone()
        {
            return new Address(this.City, this.Neighbourhood);
        }
    }
}
