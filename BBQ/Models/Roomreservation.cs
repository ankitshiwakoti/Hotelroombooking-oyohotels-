﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBQ.Models
{

    [Table("roomreservation")]
    public class Roomreservation
    {
        [Key]
        public int rrid { get; set; }

        public int roomid { get; set; }

        public DateOnly checkin { get; set; }

        public DateOnly checkout { get; set; }

        public int userid { get; set; }
    }
}
