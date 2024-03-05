using Microsoft.Extensions.Logging;
using Spg.CifBazar.DomainModel.Dtos;
using Spg.CifBazar.DomainModel.Exceptions;
using Spg.CifBazar.DomainModel.Interfaces;
using Spg.CifBazar.DomainModel.Model;
using System.Linq;

namespace Spg.CifBazar.Application.Services
{
    public class ShopService : IReadOnlyShopService, IWritableShopService
    {
        private readonly IReadOnlyShopRepository _readOnlyShopRepository;
        private readonly IWritableShopRepository _writableShopRepository;
        private readonly ILogger<Shop> _logger;

        public ShopService(
            IReadOnlyShopRepository readOnlyShopRepository, 
            IWritableShopRepository writableshopRepository, 
            ILogger<Shop> logger)
        {
            _readOnlyShopRepository = readOnlyShopRepository;
            _writableShopRepository = writableshopRepository;
            _logger = logger;
        }

        public IQueryable<ShopDto> GetAll()
        {
            // Langsam und dämlich
            //IQueryable<Shop> data = _readOnlyShopRepository.GetAll();
            //List<ShopDto> result = new List<ShopDto>();
            //foreach (Shop shop in data)
            //{
            //    result.Add(new ShopDto(shop.Name, shop.CompanySuffix));
            //}
            //return result.AsQueryable();

            // Deutlich besser mit LinQ
            return _readOnlyShopRepository
                .GetAll()
                .Select(s => new ShopDto(s.Name, s.CompanySuffix));
        }

        public ShopDto GetSingle(int id)
        {
            try
            {
                // Klassische variante
                Shop data = _readOnlyShopRepository.GetSingle(id);
                return new ShopDto(data.Name, data.CompanySuffix);
                // Besser mit z.B. Automapper
            }
            catch (ShopRepositoryReadException ex)
            {
                throw ShopServiceReadException.FromIdNotFound(id, ex);
            }
        }

        public ShopDto Create(CreateShopCommand newShop)
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
                throw new NotImplementedException();
            }
            catch (ShopRepositoryReadException ex) 
            {
                _logger.LogError($"{ex.Message} | {ex.StackTrace}");
                throw ShopServiceWriteException.FromCreate(ex);
            }
        }

        public void Delete(int id)
        {
            
        }
    }
}
