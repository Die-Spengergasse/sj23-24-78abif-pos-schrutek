namespace Spg.CifBazar.DomainModel.Dtos 
{ 
    public record ProductDto(
        string Name, 
        string Description, 
        DateOnly ExpiryDate,
        Guid ProductNumber);
} 
