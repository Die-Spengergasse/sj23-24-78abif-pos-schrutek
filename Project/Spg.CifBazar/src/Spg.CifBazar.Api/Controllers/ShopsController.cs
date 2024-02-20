using Microsoft.AspNetCore.Mvc;
using Spg.CifBazar.Application.Services;
using Spg.CifBazar.DomainModel.Dtos;
using Spg.CifBazar.DomainModel.Interfaces;
using Spg.CifBazar.DomainModel.Model;

namespace Spg.CifBazar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopsController : ControllerBase
    {
        private readonly IReadOnlyShopService _readOnlyShopService;
        private readonly IWritableShopService _writableShopService;

        public ShopsController(
            IReadOnlyShopService readOnlyShopService, 
            IWritableShopService writableShopService)
        {
            _readOnlyShopService = readOnlyShopService;
            _writableShopService = writableShopService;
        }

        // API-Design:
        // HTTP-Verben (-Methoden)
        // GET:     /api/shops ...       gibt ALLE Shops zurück
        // GET:     /api/shops/4711 ...  gibt Shop mit Id 4711 zurück
        // POST:    /api/shops ...       Erstellt einen neuen Shop  => retuniert Id
        // PUT:     /api/shops/4711 ...  Update für den Shop 4711 (Alle Felder)
        // PATCH:   /api/shops/4711 ...  Update für den Shop 4711 (Einzelne Felder)
        // DELETE:  /api/shops/4711 ...  Löscht den Shop 4711

        // GET:     /api/customers/4711/shoppingCarts   ...     liefert alle Warenkörbe für Kunde 4711
        // GET:     /api/customers/4711/shoppingCarts/123   ... liefert den Warenkorb 123 für Kunde 4711

        // GET:     /api/customers

        // URI
        // https://localhost:1234/api/customer?lastname=huber&orderby=id&oerdydirection=asc&state=A&...
        // <------URL-----------><----PATH---><----QUERY-------------------------------------------------->

        // HTTP Status-Codes
        // 200 OK
        // 201 Created
        // 300ff Redirected
        // 400ff Client Errors
        // 500ff Server Errors

        // GET https://localhost:1234/api/Shops
        [HttpGet()]
        public IActionResult GetAll(FilteredShopsQuery query)
        {
            // Service impl. +  verwenden
            return Ok(_readOnlyShopService.GetAll());
        }

        [HttpPost()]
        public IActionResult Create(CreateShopCommand newShop)
        {
            return Created("", _writableShopService.Create(newShop));
        }

        // DELETE https://localhost:1234/api/Shops/4711
        [HttpDelete("id")]
        public IActionResult DeleteAll(int id)
        {
            // Service impl. +  verwenden
            return Ok();
        }
    }
}
