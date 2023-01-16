using MagicVilla_villaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_villaAPI.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "White Villa",
                    Details = "As we all know, a paragraph is a",
                    Rate = 10,
                    Sqft = 50,
                    Ocupancy = 550,
                    ImgUrl = "https://www.google.com/search?q=jpg+image&rlz=1C1BNSD_en&oq=jpg+image&aqs=chrome..69i57j0i512l9.12808j0j7&sourceid=chrome&ie=UTF-8#imgrc=McVf5uszvVk5SM",
                    Amenity = "",
                    CreateDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Name = "new to Villa",
                    Details = " for better understanding, and to make a",
                    Sqft = 500,
                    Ocupancy = 500,
                    ImgUrl = "https://www.google.com/search?q=jpg+image&rlz=1C1BNSD_en&oq=jpg+image&aqs=chrome..69i57j0i512l9.12808j0j7&sourceid=chrome&ie=UTF-8#imgrc=ShQnriFk8AK93M",
                    Amenity = "",
                    CreateDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 3,
                    Name = "Master Villa",
                    Details = "As we all know, a paragraph is a",
                    Rate = 15,
                    Sqft = 55,
                    Ocupancy = 550,
                    ImgUrl = "https://www.google.com/search?q=jpg+image&rlz=1C1BNSD_en&oq=jpg+image&aqs=chrome..69i57j0i512l9.12808j0j7&sourceid=chrome&ie=UTF-8#imgrc=V-JSYbzQMO6IvM",
                    Amenity = "",
                    CreateDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 4,
                    Name = "Gren Villa",
                    Details = "As we all know, a paragraph is a",
                    Rate = 70,
                    Sqft = 10,
                    Ocupancy = 100,
                    ImgUrl = "https://www.google.com/search?q=jpg+image&rlz=1C1BNSD_en&oq=jpg+image&aqs=chrome..69i57j0i512l9.12808j0j7&sourceid=chrome&ie=UTF-8#imgrc=4_CKrxwlMJxE5M",
                    Amenity = "",
                    CreateDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 5,
                    Name = "Diamond Villa",
                    Details = "As we all know, a paragraph is a",
                    Rate = 40,
                    Sqft = 45,
                    Ocupancy = 100,
                    ImgUrl = "https://www.google.com/search?q=jpg+image&rlz=1C1BNSD_en&oq=jpg+image&aqs=chrome..69i57j0i512l9.12808j0j7&sourceid=chrome&ie=UTF-8#imgrc=hTEa-1tbJvTjZM",
                    Amenity = "",
                    CreateDate = DateTime.Now
                });
        }
    }
}
