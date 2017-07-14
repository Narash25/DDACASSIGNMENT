using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DDAC.Models
{
    public class Charter
    {
        [Key]
        public int ShipID { get; set; }
        [Required]
        public string ShipName { get; set; }
        [Required]
        public string ShipInfo { get; set; }
        [Required]
        public int ContainersCarried { get; set; }
    }
}