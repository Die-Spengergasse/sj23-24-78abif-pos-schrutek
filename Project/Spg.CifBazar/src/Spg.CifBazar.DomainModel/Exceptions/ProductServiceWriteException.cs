using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Exceptions
{
    public class ProductServiceWriteException : Exception
    {
        public ProductServiceWriteException()
            : base()
        { }

        public ProductServiceWriteException(string? message)
            : base(message)
        { }

        public ProductServiceWriteException(string? message, Exception? innerException)
            : base(message, innerException)
        { }

        public static ProductServiceWriteException FromCreate(Exception? innerException)
        {
            return new ProductServiceWriteException($"Produkt konnte nicht angelegt werden!", innerException);
        }
    }
}
