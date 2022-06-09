using Kolokwium2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kolokwium2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SamplesController : ControllerBase
    {
        public readonly IDbSqlServer _sqlServer;
        //ZMIENIĆ NAZWĘ TRZEBA!!!!
        public SamplesController(IDbSqlServer sqlServer)
        {
            _sqlServer = sqlServer;
        }

    }
}
