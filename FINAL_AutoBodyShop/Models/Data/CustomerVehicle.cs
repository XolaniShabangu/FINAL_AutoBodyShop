using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FINAL_AutoBodyShop.Models.Data
{
    public class CustomerVehicle
    {
        [Key]
        [Display(Name = "Number Plate")]
        public string Number_Plate{ get; set; }

        //public int? Id { get; set; }
        //[ForeignKey("Id")]
        //public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        [Display(Name = "Vehicle Brand Name")]
        public string Vehicle_Name { get; set; }
        [Required]
        [Display(Name = "Model")]
        public  string Car_Model { get; set; }
        [Required]
        [Range(2000,2024)]
        public int Year{ get; set; }       
        [Required]
        [Display(Name = "Current Mileage")]
        public decimal Current_Mileage { get; set; }
        [Required]
        [Display(Name = "Engine Type(Diesel or Petrol)")]
        public string Engine_Type { get; set; }
        [Required]
        [Display(Name = "Does the car have a Service History")]
        public bool Service_History { get; set; }

    }
}