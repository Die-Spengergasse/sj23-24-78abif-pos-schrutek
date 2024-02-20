using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Spg.CifBazar.DomainModel.Exceptions
{
    public class ShopRepositoryReadException : Exception
    {
        public ShopRepositoryReadException() 
        { }

        public ShopRepositoryReadException(string? message)
            : base(message)
        { }

        public ShopRepositoryReadException(string? message, Exception? innerException)
            : base(message, innerException)
        { }

        public static ShopRepositoryReadException FromIdNotFound(int id)
        {
            return new ShopRepositoryReadException($"Shop mit der ID:{id} ist nicht vorhanden");
        }

        public static ShopRepositoryReadException FromNameIsNotUnique(string name)
        {
            return new ShopRepositoryReadException($"Shop mit dem Namen {name} ist bererits vorhanden");
        }
    }
}
