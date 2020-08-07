using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BiletaraKino.Models
{
    public class CinemaRoom
    {
        public CinemaRoom()
        {
            Movies = new List<Movie>();
        }

        [Key]
        public int CinemaRoomId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1, 20, ErrorMessage = "Enter a valid number for room")]
        public int Number { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}