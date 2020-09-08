using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class DropOffAreaModel
    {
        [Display(Name = "ID")]
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name = "DropOffArea")]
        public string DropOffArea { get; set; }

        [Required]
        [Display(Name = "TimeArrival")]
        public string TimeArrival { get; set; }

        [Required]
        [Display(Name = "TimeDepture")]
        public string TimeDepature { get; set; }

        [Required]
        [Display(Name = "DriverID")]

        public int DriverID { get; set; }
    }
}
