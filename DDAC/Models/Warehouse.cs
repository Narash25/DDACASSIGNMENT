using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DDAC.Models
{
    public class Warehouse
    {
        [Key]
        public int WarehouseNo{ get; set; }
        [Required]
        public string WarehouseName { get; set; }
        [Required]
        public string Manager { get; set; }
        [Required]
        public int ContainerStored { get; set; }
    }
}