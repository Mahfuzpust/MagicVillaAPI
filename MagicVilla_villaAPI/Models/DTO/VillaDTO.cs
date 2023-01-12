using System.ComponentModel.DataAnnotations;

namespace MagicVilla_villaAPI.Models.DTO
{
    public class VillaDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public double Cgpa { get; set; }
        public int Age { get; set; }
    }
}
