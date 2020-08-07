using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BiletaraKino.Models
{
    public class CinemaRoomMovie
    {
        public Movie movie { get; set; }
        public List<CinemaRoom> cinemaRooms { get; set; }
        public int mId { get; set; }
        public int crId { get; set; }
    }
}