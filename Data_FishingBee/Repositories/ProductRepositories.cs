using Data_FishingBee.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_FishingBee.Repositories
{
    public class ProductRepositories : IAllRepositories<Product>
    {
        private readonly FishingBeeDbContext _db;

        public ProductRepositories(FishingBeeDbContext db)
        {
            _db = db;
        }

        public async Task<Product> Create(Product Obj)
        {
            try
            {
                _db.Products.Add(Obj);
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
                _db.Products.Remove(delObj);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _db.Products.ToListAsync();
        }

        public async Task<Product> GetById(Guid id)
        {
            return await _db.Products.FindAsync(id);
        }

        public async Task Update(Guid id, Product Obj)
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
