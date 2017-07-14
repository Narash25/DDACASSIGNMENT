using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace DDAC.Models
{
    public class Shipyard
    {
        
            [Key]
            public int ShipyardID { get; set; }
            [Required]
            public string YardName { get; set; }
            [Required]
            public int DockedShip { get; set; }
            [Required]
            public int DockNumber { get; set; }
            [Required]
            public int TotalContainers { get; set; }
        

    }
}