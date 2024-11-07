using Data_FishingBee.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_FishingBee.Repositories
{
    public class ProductDetailRepositories : IAllRepositories<ProductDetail>
    {
        private readonly FishingBeeDbContext _db;

        public ProductDetailRepositories(FishingBeeDbContext db)
        {
            _db = db;
        }

        public async Task<ProductDetail> Create(ProductDetail Obj)
        {
            try
            {
                _db.ProductDetail.Add(Obj);
                await _db.SaveChangesAsync();
                return Obj;
            }
            catch
            {
                return null;
            }
        }

        public async Task Delete(Guid id)
        {
            var delObj = await GetById(id);
            if (delObj != null)
            {
                _db.ProductDetail.Remove(delObj);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<ProductDetail>> GetAll()
        {
            return await _db.ProductDetail.ToListAsync();
        }

        public async Task<ProductDetail> GetById(Guid id)
        {
            return await _db.ProductDetail.FindAsync(id);
        }

        public async Task Update(Guid id, ProductDetail Obj)
        {
            var updateObj = await GetById(id);
            if (updateObj != null)
            {
                _db.Entry(updateObj).CurrentValues.SetValues(Obj);
                await _db.SaveChangesAsync();
            }
        }
    }
}
