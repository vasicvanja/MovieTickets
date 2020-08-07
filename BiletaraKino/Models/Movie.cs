using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BiletaraKino.Models
{
    public class Movie
    { 
        public Movie()
        {
            CinemaRooms = new List<CinemaRoom>();
        }

        [Key]
        public int MovieId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Image")]
        public string ImageURL { get; set; }
        [Required]
        public double Rating { get; set; }
        public virtual ICollection<CinemaRoom> CinemaRooms { get; set; }
    }
}