using Kolokwium2.Contexts;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Services
{
    public class DbSqlServer : IDbSqlServer
    {
        private readonly MainDbContext _context;

        public DbSqlServer(MainDbContext context)
        {
            _context = context;
        }

    }
}
