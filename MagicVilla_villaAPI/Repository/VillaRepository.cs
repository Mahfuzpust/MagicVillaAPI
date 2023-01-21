using MagicVilla_villaAPI.Data;
using MagicVilla_villaAPI.Models;
using MagicVilla_villaAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;

namespace MagicVilla_villaAPI.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdateDate = DateTime.Now;
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
