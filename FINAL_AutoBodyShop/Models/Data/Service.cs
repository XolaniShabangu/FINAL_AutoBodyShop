using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FINAL_AutoBodyShop.Models.Data
{
    public class Service
    {
        [Key]
        [Required]
        [Display(Name ="Service Id")]
        public  string Service_Id { get; set; }
        [Required]
        [Display(Name = "Number Plate")]
        public string Number_Plate{ get; set; }
        [Required]
        [Display(Name = "Service Type")]
        public string Service_Type { get; set; }
        public bool Battery_Test { get; set; }
        public bool Oil_Filter { get; set; }
        public bool Air_Filter { get; set; }
        public bool Brake_Fluid { get; set; }
        public bool Brake_Pads { get; set; }
        public bool Engine_Oil { get; set; }
        public bool WindShield_Wipers{ get; set; }

        [Required]
        [Display(Name = "Service Date")]
        public DateTime Service_Date { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Employee Id")]
        public string Emoployee_Id { get; set; }

    }
}