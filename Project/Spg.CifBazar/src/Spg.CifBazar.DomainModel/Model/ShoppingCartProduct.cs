using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Model
{
    public class ShoppingCartProduct
    {
        private ShoppingCartProduct()
        { }
        public ShoppingCartProduct(
            DateTime buyingDateTime, 
            int pieces, 
            Product product, 
            ShoppingCart shoppingCartNavigation, 
            DateTime creationTime)
        {
            BuyingDateTime = buyingDateTime;
            Pieces = pieces;
            Product = product;
            ShoppingCartNavigation = shoppingCartNavigation;
            CreationTime = creationTime;
        }

        public int Id { get; private set; }
        public DateTime BuyingDateTime { get; private set; }
        public int Pieces { get; set; }
        public Product Product { get; set; } = default!;
        public ShoppingCart ShoppingCartNavigation { get; set; } = default!;
        public DateTime CreationTime { get; private set; }
    }
}
