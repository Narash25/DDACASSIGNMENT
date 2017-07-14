using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DDAC.Models
{
    public class Booking
    {
     [Key]
        public int BookingID { get; set; }
    [Required]
        public int ShipID { get; set; }
     [Required]
        public int ContainerID { get; set; }
     [Required]
        public int Price { get; set; }
     [Required]
        public int Date { get; set; }
     [Required]
        public int Time { get; set; }
     [Required]
        public int Departure { get; set; }
     [Required]
        public int Arrival { get; set; }
    }
}