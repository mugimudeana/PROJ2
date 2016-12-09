using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PROJECT1.Models
{
    [Table("Missions")]
    
    public class Missions
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int MissionID { get; set; }

         [HiddenInput(DisplayValue = false)]
        [DisplayName("Mission Name")]
        public string MissionName { get; set; }

         [HiddenInput(DisplayValue = false)]
        [DisplayName("President Name")]
        public string PresidentName { get; set; }

         [HiddenInput(DisplayValue = false)]
        [DisplayName("Mission Address")]
        public string MissionAddress { get; set; }

        [HiddenInput(DisplayValue = false)]
        [DisplayName("Language")]
        public string Language { get; set; }

         [HiddenInput(DisplayValue = false)]
        [DisplayName("Climate")]
        public string Climate { get; set; }

         [HiddenInput(DisplayValue = false)]
        [DisplayName("Dominant Religion")]
        public string DominantReligion { get; set; }

         [HiddenInput(DisplayValue = false)]
        [DisplayName("Flag")]
        public string Flag { get; set; }


    }
}