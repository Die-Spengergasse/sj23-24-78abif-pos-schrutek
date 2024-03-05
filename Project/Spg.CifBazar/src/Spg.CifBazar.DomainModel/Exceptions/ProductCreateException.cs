namespace Spg.CifBazar.DomainModel.Exceptions 
{ 
    public class ProductCreateException : Exception
    {
        public ProductCreateException()
        { }

        public ProductCreateException(string? message)
            : base(message)
        { }

        public ProductCreateException(string? message, Exception? innerException)
            : base(message, innerException)
        { }

        public static ProductCreateException FromCategoryNotFound(int id)
        {
            return new ProductCreateException($"Kategorie mit der ID: {id} wirde nicht gefunden!");
        }
    } 
} 
