using Kolokwium2.DTOs;
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

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> getMusicanDetails(int id)
        {

            if (!await _sqlServer.musicanExist(id))
            {
                return NotFound("Musican not found");
            }

            Musican_DTO musican = await _sqlServer.getMusicanDetails(id);


            return Ok(musican);

        }

    }
}
