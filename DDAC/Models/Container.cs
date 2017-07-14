using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DDAC.Models
{
    public class Container
    {
        [Key]
        public int ContainerID { get; set; }
        [Required]
        public string ContainerName { get; set; }
        [Required]
        public string ContainerInfo { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public double Weight { get; set; }
    }
}