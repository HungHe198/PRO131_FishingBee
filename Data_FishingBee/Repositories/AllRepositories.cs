using Data_FishingBee.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Data_FishingBee.Repositories
{
    public class AllRepositories<H> : IAllRepositories<H> where H : class
    {
        private readonly FishingBeeDbContext _db;
        DbSet<H> _dbSet;

        public AllRepositories(FishingBeeDbContext db, DbSet<H> dbSet)
        {
            _db = db;
            _dbSet = dbSet;
        }

        public bool CreateObj(H Obj)
        {
            try
            {
                _dbSet.Add(Obj);
                _db.SaveChanges();
                return true;
            }
            catch (Exception Ex){ 
           return false;
            }
        }
        public bool UpdateObj(H Obj)
        {
            try
            {
                _dbSet.Update(Obj);
                _db.SaveChanges();
                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }
        public bool DeletedObj(dynamic id)
        {
            try
            {
                var objDel = _db.Find(id);
                _dbSet.Remove(objDel);
                _db.SaveChanges();
                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        public ICollection<H> GetAll()
        {
           return _dbSet.ToList();

        }

        public H GetById(dynamic id)
        {
            return _dbSet.Find(id);
        }

        
    }
}
