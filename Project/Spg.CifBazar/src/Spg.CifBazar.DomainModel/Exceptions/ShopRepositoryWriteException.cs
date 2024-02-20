using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Exceptions
{
    public class ShopRepositoryWriteException : Exception
    {
        public ShopRepositoryWriteException()
        { }

        public ShopRepositoryWriteException(string? message)
            : base(message)
        { }

        public ShopRepositoryWriteException(string? message, Exception? innerException)
            : base(message, innerException)
        { }

        public static ShopRepositoryWriteException FromCreate(Exception? innerException)
        {
            return new ShopRepositoryWriteException($"Shop konnte nicht erstellt werden!", innerException);
        }

        public static ShopRepositoryWriteException FromUpdate(Exception? innerException)
        {
            return new ShopRepositoryWriteException($"Shop konnte nicht aktualisiert werden!", innerException);
        }

        public static ShopRepositoryWriteException FromDelete(Exception? innerException)
        {
            return new ShopRepositoryWriteException($"Shop konnte nicht gelöscht werden!", innerException);
        }
    }
}
