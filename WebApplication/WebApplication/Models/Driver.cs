using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Driver
    {
        [Display(Name = "ID")]
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Email")]

        public string Email { get; set; }

        [Required]
        [Display(Name = "Cell")]
        public string Cell { get; set; }

        [Required]
        [Display(Name = "DriverType")]
        public string DriverType { get; set; }

        [Required]
        [Display(Name = "Account State")]
        public string AccountActive { get; set; }

        [Required]
        [Display(Name = "Has Driver")]
        public int HasVehicle { get; set; }




        [Required]
        [Display(Name = "Has Driver")]
        public string VehicleName { get; set; }


        [Required]
        [Display(Name = "Has Driver")]
        public string VehicleDescription { get; set; }


        [Required]
        [Display(Name = "Has Driver")]
        public string VehicleType { get; set; }


        [Required]
        [Display(Name = "Has Driver")]
        public int VehicleCapacity { get; set; }


        [Required]
        [Display(Name = "Has Driver")]
        public string VehicleStateDescription { get; set; }


        [Required]
        [Display(Name = "Has Driver")]
        public string VehicleDateAdded { get; set; }


        [Required]
        [Display(Name = "Has Driver")]
        public string VehicleRegistration
        { get; set;
        }
        } }

