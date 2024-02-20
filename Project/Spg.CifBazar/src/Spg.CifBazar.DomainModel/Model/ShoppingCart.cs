using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Model
{
    public class ShoppingCart
    {
        public int Id { get; private set; }
        public DateTime CreationTime { get; private set; }
        public Person PersonNavigation { get; set; } = default!;
        //public ShoppingCartStatus Status { get; set; }
    }
}
