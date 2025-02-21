using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SteelHorseTrucks.Models
{
    public class Trucks
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string? Model { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [Display(Name = "Payload Capacity")]
        public decimal PayloadCapacity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        public int Warranty { get; set; }
    }
}
