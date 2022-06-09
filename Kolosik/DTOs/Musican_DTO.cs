using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.DTOs
{
    public class Musican_DTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }

        public List<Track_DTO> tracks { get; set; }
    }
}
