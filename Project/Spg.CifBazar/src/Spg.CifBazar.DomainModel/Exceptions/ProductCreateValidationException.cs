using Spg.CifBazar.DomainModel.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Exceptions
{
    public class ProductCreateValidationException : Exception
    {
        public ProductCreateValidationException()
        { }

        public ProductCreateValidationException(string? message)
            : base(message)
        { }

        public ProductCreateValidationException(string? message, Exception? innerException)
            : base(message, innerException)
        { }

        public static ProductCreateValidationException FromNameIsNotUnique(CreateProductCommand command)
        {
            return new ProductCreateValidationException($"Der Produktname {command.Name} ist bereits vergeben!");
        }
        public static ProductCreateValidationException FromInvalidExpiryDate(DateTime expiryDate)
        {
            return new ProductCreateValidationException($"Das Ablaufdatum {expiryDate} ist bereits überschritten!");
        }
        public static ProductCreateValidationException FromInvalidPrice()
        {
            return new ProductCreateValidationException($"Das Produkt muss einen gültigen Preis haben!");
        }
        public static ProductCreateValidationException FromInvalidWhatEver()
        {
            return new ProductCreateValidationException($"Weitere Bedingung...!");
        }
        //...
    }
}
