using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Exceptions
{
    public class ProductRepositoryWriteException : Exception
    {
        public ProductRepositoryWriteException()
            : base()
        { }

        public ProductRepositoryWriteException(string? message)
            : base(message)
        { }

        public ProductRepositoryWriteException(string? message, Exception? innerException)
            : base(message, innerException)
        { }

        public static ProductRepositoryWriteException FromCreate(Exception? innerException)
        {
            return new ProductRepositoryWriteException($"Produkt konnte nicht angelegt werden!", innerException);
        }
    }
}
