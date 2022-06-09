using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Models
{
    public class Track
    {
        [Key]
        public int IdTrack { get; set; }
        [Required]
        [MaxLength(20)]
        public string TrackName { get; set; }
        [Required]
        public float Duration { get; set; }

        public int IdMusicAlbum_FK { get; set; }

        public virtual ICollection<Musican_Track> Musican_Tracks { get; set; }
  
        [ForeignKey("IdMusicAlbum_FK")]
        public virtual Album Album { get; set; }
    }
}
