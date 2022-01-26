using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AnimeNerdApp.Models
{
    public class Anime
    {
        [Key]
        public int AnimeId { get; set; }
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        [StringLength(25)]
        public string Genre { get; set; }
        [Range(5,10)]
        [DisplayName("Husbandos")]
        public int NumberOfHusbandos { get; set; }
        [Range(1,300)]
        [DisplayName("Series Length")]
        public int NumberOfEpisodes { get; set; }
    }
}
