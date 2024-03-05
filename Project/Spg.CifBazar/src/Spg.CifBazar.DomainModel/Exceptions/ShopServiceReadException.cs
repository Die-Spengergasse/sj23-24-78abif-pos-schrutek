using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Exceptions
{
    public class ShopServiceReadException : Exception
    {
        public ShopServiceReadException()
            : base()
        { }

        public ShopServiceReadException(string? message)
            : base(message)
        { }

        public ShopServiceReadException(string? message, Exception? innerException)
            : base(message, innerException)
        { }

        public static ShopServiceReadException FromIdNotFound(int id, Exception? innerException)
        {
            return new ShopServiceReadException($"Shop mit der ID:{id} ist nicht vorhanden", innerException);
        }
    }
}
