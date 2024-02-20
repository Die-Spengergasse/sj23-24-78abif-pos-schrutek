using Microsoft.Extensions.Logging;
using Spg.CifBazar.DomainModel.Dtos;
using Spg.CifBazar.DomainModel.Exceptions;
using Spg.CifBazar.DomainModel.Interfaces;
using Spg.CifBazar.DomainModel.Model;
using System.Linq;

namespace Spg.CifBazar.Application.Services
{
    public class ShopService : IReadOnlyShopService
    {
        private readonly IReadOnlyShopRepository _readOnlyshopRepository;
        private readonly IWritableShopRepository _writableshopRepository;
        private readonly ILogger<Shop> _logger;

        public ShopService(
            IReadOnlyShopRepository readOnlyShopRepository, 
            IWritableShopRepository writableshopRepository, 
            ILogger<Shop> logger)
        {
            _readOnlyshopRepository = readOnlyShopRepository;
            _writableshopRepository = writableshopRepository;
            _logger = logger;
        }

        public IQueryable<ShopDto> GetAll()
        {
            return _readOnlyshopRepository.GetAll();
        }

        public ShopDto GetSingle(int id)
        {
            try
            {
                return _readOnlyshopRepository.GetSingle(id);
            }
            catch (ShopRepositoryReadException ex)
            {
                throw ShopServiceReadException.FromIdNotFound(id, ex);
            }
        }

        public Shop Create(Shop newShop)
        {
            _logger.LogInformation("Service - Create Shop (Initialisation)");

            _logger.LogInformation("Service - Create Shop (Validation of Input Data)");
            _logger.LogInformation("Check Shop Name (must be unique)");
            //...

            _logger.LogInformation("Validation OK, Create new Shop Entity");

            _logger.LogInformation("Service - Call Respository and persist to Database");
            try
            {
                _logger.LogInformation("Everything OK");
                return _writableshopRepository.Create(newShop);
            }
            catch (ShopRepositoryReadException ex) 
            {
                _logger.LogError($"{ex.Message} | {ex.StackTrace}");
                throw; // throw ShopServiceWriteException.FromCreate("...");
            }
        }

        public void Delete(int id)
        {
            
        }
    }
}
