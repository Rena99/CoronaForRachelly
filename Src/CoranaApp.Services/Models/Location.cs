using System;
using System.ComponentModel.DataAnnotations;

namespace CoronaApp.Services
{
    public class Location
    {
        public int Id { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string LocationC { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required]
        public int PatientId { get; set; }
    }
}