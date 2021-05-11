using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TP5_Chotsourian.API.Models
{
    public class TerritoriesAPI
    {
        [Key]
        [StringLength(20)]
        public string TerritoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string TerritoryDescription { get; set; }

        public int RegionID { get; set; }
    }
}