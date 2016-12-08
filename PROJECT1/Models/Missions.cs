using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PROJECT1.Models
{
    [Table("Missions")]
    
    public class Missions
    {
        [Key]
        [DisplayName("Mission ID")]
        public int MissionID { get; set; }

        [DisplayName("Mission Name")]
        [Required(ErrorMessage = "Please enter Mission Name")]
        public string MissionName { get; set; }

        [DisplayName("President Name")]
        [Required(ErrorMessage = "Please enter President Name")]
        public string PresidentName { get; set; }

        [DisplayName("Mission Address")]
        [Required(ErrorMessage = "Please enter Mission Address")]
        public string MissionAddress { get; set; }

        [DisplayName("Language")]
        [Required(ErrorMessage = "Please enter Language")]
        public string Language { get; set; }

        [DisplayName("Climate")]
        public string Climate { get; set; }

        [DisplayName("Dominant Religion")]
        public string DominantReligion { get; set; }

        [DisplayName("Flag")]
        public string Flag { get; set; }


    }
}