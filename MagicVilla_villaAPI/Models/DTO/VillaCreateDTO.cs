using System.ComponentModel.DataAnnotations;

namespace MagicVilla_villaAPI.Models.DTO
{
    public class VillaCreateDTO
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Details { get; set; }
        public double Rate { get; set; }
        public int Sqft { get; set; }
        public int Ocupancy { get; set; }
        public string ImgUrl { get; set; }
        public string Amenity { get; set; }
        public int VillaNo { get; internal set; }
    }
}
