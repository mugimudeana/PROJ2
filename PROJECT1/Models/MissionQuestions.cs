using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PROJECT1.Models
{
    [Table("MissionQuestions") ]

    public class MissionQuestions
    {
        [Key]
        [DisplayName("Mission Question")]
        public int MissionQuestionID { get; set; }

        [DisplayName("Mission ID")]
        [Required(ErrorMessage = "Please enter MissionID")]
        public string MissionID { get; set; }

        [DisplayName("User")]
        [Required(ErrorMessage = "Please enter UserID")]
        public string UserID { get; set; }

        [DisplayName("Question")]
        [Required(ErrorMessage = "Please enter question")]
        public string Question { get; set; }

        [DisplayName("Answer")]
        [Required(ErrorMessage = "Please enter answer")]
        public string Answer { get; set; }


    }
}