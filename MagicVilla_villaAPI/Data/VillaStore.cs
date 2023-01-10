using MagicVilla_villaAPI.Models;
using MagicVilla_villaAPI.Models.DTO;

namespace MagicVilla_villaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO{Id = 1, Name = "Mahfuz", Cgpa=3.79, Age=23 },
                new VillaDTO{Id = 2, Name = "Mahfuz Khan", Cgpa=3.57, Age=23 },
                new VillaDTO{Id = 3, Name = "Mahfuz khan Raj", Cgpa=3.45, Age=23 },
                new VillaDTO{Id = 3, Name = "Raj", Cgpa=3.32, Age=23 },
            };
    }
}
