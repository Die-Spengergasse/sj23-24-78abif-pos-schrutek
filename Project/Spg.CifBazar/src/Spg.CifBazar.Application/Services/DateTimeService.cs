using Spg.CifBazar.DomainModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.Application.Services
{
    public class DateTimeService : IDateTimeService
    {
        // Echtes Datum von heute
        public DateTime Now
            => DateTime.Now;

        public void Whatever()
        {
            //...
        }
    }
}
