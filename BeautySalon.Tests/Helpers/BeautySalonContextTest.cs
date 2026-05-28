using BeautySalon.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Tests.Helpers
{
    public class BeautySalonContextTest
    {
        public static BeautySalonContext CreateContext()
        {
            var options = new DbContextOptionsBuilder<BeautySalonContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            BeautySalonContext context = new BeautySalonContext(options);
            context.Database.EnsureCreated();

            return context;
        }
    }
}
