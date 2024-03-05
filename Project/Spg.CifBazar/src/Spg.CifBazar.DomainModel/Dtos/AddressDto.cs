namespace Spg.CifBazar.DomainModel.Dtos
{
    public record AddressDto(
        string Street, 
        string HouseNumber, 
        string Zip, 
        string Country);
}
