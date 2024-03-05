using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Exceptions
{
    public class ShopServiceWriteException : Exception
    {
        public ShopServiceWriteException()
            : base()
        { }

        public ShopServiceWriteException(string? message)
            : base(message)
        { }

        public ShopServiceWriteException(string? message, Exception? innerException)
            : base(message, innerException)
        { }

        public static ShopServiceWriteException FromCreate(Exception? innerException)
        {
            return new ShopServiceWriteException($"Shop konnte nicht angelegt werden!", innerException);
        }
    }
}
