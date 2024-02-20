using Spg.CifBazar.DomainModel.Model;

namespace Spg.CifBazar.DomainModel.Test.Helpers 
{ 
    public static class DatabaseUtilities 
    {
        public static List<Shop> GetSeedingShops()
        {
            return new List<Shop>()
            {
                new Shop("Super Shop", "GMBH",
                    new Address("Street1", "4711A", "City1", "6512"),
                    new PhoneNumber("0123", "123456789"),
                    new EMail("super_shop@gmx.at")),
                new Shop("Online Dings", "KG",
                    new Address("Street2", "1323B", "City1", "1245"),
                    new PhoneNumber("0123", "123456789"),
                    new EMail("online@dings.at")),
                new Shop("Krimskrams", "AG",
                    new Address("Street3", "4535C", "City1", "1212"),
                    new PhoneNumber("0123", "123456789"),
                    new EMail("krimskrams@gmx.at")),
            };
        }

        public static List<Category> GetSeedingCategories(List<Shop> shops)
        {
            return new List<Category>()
            {
                new Category("Kleidung", shops.ElementAt(0)),
                new Category("Elektronik", shops.ElementAt(0)),
                new Category("Haushalt", shops.ElementAt(0)),
                new Category("Mobilfunk", shops.ElementAt(0)),
                new Category("Getränke", shops.ElementAt(1)),
                new Category("Kleidung", shops.ElementAt(1)),
                new Category("Werkzeug", shops.ElementAt(2)),
                new Category("Garten", shops.ElementAt(2)),
                new Category("Elektronik", shops.ElementAt(2))
            };
        }

        public static List<Product> GetSeedingProducts(List<Category> categories)
        {
            return new List<Product>()
            {
                new Product("Dings", "asddadsdsa", DateOnly.FromDateTime(DateTime.Now.AddDays(30)), categories.ElementAt(0)),
                new Product("Scharubenzieher", "qweeqweqweqw", DateOnly.FromDateTime(DateTime.Now.AddDays(12)), categories.ElementAt(0)),
                new Product("Telefon", "ascxyyxccxy", DateOnly.FromDateTime(DateTime.Now.AddDays(34)), categories.ElementAt(2)),
                new Product("Handy", "cxvxcv", DateOnly.FromDateTime(DateTime.Now.AddDays(32)), categories.ElementAt(4)),
                new Product("T-Shirt", "sfdxvccvbccncnb", DateOnly.FromDateTime(DateTime.Now.AddDays(18)), categories.ElementAt(0)),
                new Product("Socken", "n dfgbadvsf<sdnmgfhdy v", DateOnly.FromDateTime(DateTime.Now.AddDays(92)), categories.ElementAt(0)),
                new Product("Socken2", "xcvyfds ", DateOnly.FromDateTime(DateTime.Now.AddDays(14)), categories.ElementAt(4)),
                new Product("T-Shirt2", "drzjkjhgfhjhfbfvdf", DateOnly.FromDateTime(DateTime.Now.AddDays(71)), categories.ElementAt(4)),
                new Product("Stabmixer", "sdfgtkjhhgfewehtfgbfx", DateOnly.FromDateTime(DateTime.Now.AddDays(25)), categories.ElementAt(1)),
                new Product("Cocal Cola", "fsewertuizoplkhjgfd", DateOnly.FromDateTime(DateTime.Now.AddDays(37)), categories.ElementAt(3)),
                new Product("Bier", "dsafgjhkukjfhdgsadvcx", DateOnly.FromDateTime(DateTime.Now.AddDays(88)), categories.ElementAt(3)),
                new Product("Schneeschaufel", "erwzutkghnbvfetrzukjgh", DateOnly.FromDateTime(DateTime.Now.AddDays(45)), categories.ElementAt(8)),
                new Product("Blumen", "sertzuiokjhgfdcx", DateOnly.FromDateTime(DateTime.Now.AddDays(5)), categories.ElementAt(5)),
                new Product("Wein", "wqertzuiopoiuzhgvcfgnj", DateOnly.FromDateTime(DateTime.Now.AddDays(58)), categories.ElementAt(8)),
                new Product("Unterhose", "mnbvfdertzuiokjhgfc", DateOnly.FromDateTime(DateTime.Now.AddDays(13)), categories.ElementAt(8)),
            };
        }
    }
} 
