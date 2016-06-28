namespace StudentClass.Contracts
{
    using Models.AddressEnumerations;

    public interface IAddress
    {
        CityType City { get; set; }

        NeighbourhoodType Neighbourhood { get; set; }
    }
}
