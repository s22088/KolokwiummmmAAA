using Kolokwium2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kolokwium2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicansController : ControllerBase
    {
        public readonly IDbSqlServer _sqlServer;
        public MusicansController(IDbSqlServer sqlServer)
        {
            _sqlServer = sqlServer;
        }

    }
}
