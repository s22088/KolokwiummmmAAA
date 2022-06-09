using Kolokwium2.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kolokwium2.Services
{
    public interface IDbSqlServer
    {
        public Task<Musican_DTO> getMusicanDetails(int id);
        public Task<bool> musicanExist(int id);
    }
}
