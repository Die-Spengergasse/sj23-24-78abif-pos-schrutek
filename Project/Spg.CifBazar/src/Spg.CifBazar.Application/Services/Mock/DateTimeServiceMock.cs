using Spg.CifBazar.DomainModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.Application.Services.Mock
{
    public class DateTimeServiceMock : IDateTimeService
    {
        // Fake-Datum
        public DateTime Now
            => new DateTime(2024, 02, 05);
    }
}
