using Kolokwium2.Contexts;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Kolokwium2.DTOs;

namespace Kolokwium2.Services
{
    public class DbSqlServer : IDbSqlServer
    {
        private readonly MainDbContext _context;

        public DbSqlServer(MainDbContext context)
        {
            _context = context;
        }

        public async Task<Musican_DTO> getMusicanDetails(int id)
        {
            return await (from mt in _context.Musican_Tracks
                          join m in _context.Musicans on mt.IdMusican equals m.IdMusican
                          where m.IdMusican == id

                          select new Musican_DTO
                          {
                              FirstName = m.FirstName,
                              LastName = m.LastName,
                              Nickname = m.Nickame,

                              tracks = _context.Musican_Tracks
                                        .Join(_context.Tracks, mut => mut.IdTrack, t => t.IdTrack, (mut, t) => new { TrackName = t.TrackName, Duration = t.Duration })
                                        .Select(e => new Track_DTO { TrackName = e.TrackName, Duration = e.Duration })
                                        .OrderBy(e => e.Duration)
                                        .ToList()

                          }).FirstOrDefaultAsync();
        }

        public async Task<bool> musicanExist(int id)
        {
            var queryToFind = await (from m in _context.Musicans
                                     where m.IdMusican == id
                                     select m).FirstOrDefaultAsync();

            if (queryToFind == null || queryToFind.IdMusican != id)
            {
                return false;
            }

            return true;
        }
    }
}
