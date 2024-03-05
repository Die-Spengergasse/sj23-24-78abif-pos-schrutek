using Azure.Identity;
using Spg.CifBazar.DomainModel.Dtos;
using Spg.CifBazar.DomainModel.Exceptions;
using Spg.CifBazar.DomainModel.Interfaces;
using Spg.CifBazar.DomainModel.Model;
using Spg.CifBazar.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.Application.Services
{
    public class ProductService : IReadOnlyProductService, IWritableProductService
    {
        private readonly IReadOnlyCategoryRepository _readOnlyCategoryRepository;
        private readonly IReadOnlyProductRepository _readOnlyProductRepository;
        private readonly IWritableProductRepository _writableProductRepository;

        public ProductService(
            IReadOnlyCategoryRepository categoryRepository,
            IReadOnlyProductRepository productRepository,
            IWritableProductRepository writableProductRepository)
        {
            _readOnlyCategoryRepository = categoryRepository;
            _readOnlyProductRepository = productRepository;
            _writableProductRepository = writableProductRepository;
        }

        public void Create(CreateProductCommand productCommand)
        {
            //////////// Init (Produkt muss in eine bestimmte Kategorie)
            //////////Category? category = _readOnlyCategoryRepository.GetCategoryById(product.CategroyId)
            //////////    ?? throw ProductCreateException.FromCategoryNotFound(product.CategroyId);

            //////////// Validation
            //////////// * Name muss eindeutig sein
            //////////if (_readOnlyProductRepository.FilterBuilder.ApplyNameContainsFilter(product.Name).Build().Count() > 0)
            //////////{
            //////////    throw ProductCreateValidationException.FromNameIsNotUnique(product);
            //////////}
            //////////// * Ablaufdatum muss in der Zukunft liegen
            //////////// if(...)

            //////////// Alles OK
            //////////// _writableProductRepository...


            // TODO: Test Driven Development!!

            // Init
            // * Die Category muss existieren
            Category existingCategory = _readOnlyCategoryRepository.GetCategoryById(productCommand.CategroyId)
                ?? throw new ProductCreateValidationException(
                    $"Die Kategiorie (ID: {productCommand.CategroyId}) wurde nicht gefunden!");

            // Validation
            // * Ablaufdatum muss 14 Tage in der Zukunft liegen
            if (productCommand.ExpiryDate < DateTime.Now.AddDays(14))
            {
                throw new ProductCreateValidationException(
                    $"Das Ablaufdatum muss mind. 14 Tage in der Zukunft liegen!");
            }
            // * Produktname muss pro Kategorie eindeutig sein
            // * ...

            // Act
            Product product = new Product(
                productCommand.Name, 
                productCommand.Description, 
                DateOnly.FromDateTime(productCommand.ExpiryDate), 
                existingCategory);

            // Persist
            _writableProductRepository.Create(product);
        }
    }
}
