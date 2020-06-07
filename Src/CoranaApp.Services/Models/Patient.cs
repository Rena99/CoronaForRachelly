using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoronaApp.Services
{
    public class Patient
    {
        public Patient()
        {
            Path = new List<Location>();
        }

        [Required]
        [StringLength(9)]
        public int Id { get; set; }

        [Required]
        [Range(0, 120)]
        public int Age { get; set; }
        public List<Location> Path { get; set; }
    }
}