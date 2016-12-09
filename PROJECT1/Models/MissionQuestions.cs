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
    [Table("MissionQuestions") ]

    public class MissionQuestions
    {
        [Key]
        
        public int MissionQuestionID { get; set; }
        [DisplayName("Mission Question")]
        

       
        public int MissionID { get; set; }
        [DisplayName("User")]

       
        public int UserID { get; set; }

        [DisplayName("Question")]
        public string Question { get; set; }

        [DisplayName("Answer")]
        public string Answer { get; set; }


    }
}