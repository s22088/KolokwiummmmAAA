using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Models
{
    public class Musican
    {
        [Key]
        public int IdMusican { get; set; }
        [Required]
        [MaxLength(30)]

        public string  FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string  LastName { get; set; }
        [Required]
        [MaxLength(20)]
        public string Nickame { get; set; }

        public virtual ICollection<Musican_Track> Musican_Tracks { get; set; }
    }
}
