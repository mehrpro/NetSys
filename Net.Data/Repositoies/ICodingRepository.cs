using Microsoft.EntityFrameworkCore;
using Net.Data.Infrastructure;
using Net.Entities.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Net.Data.Repositoies
{
    public interface ICodingRepository : IRepository<Coding>
    {
        //------Definition Private Functions Model -------------//
        IList<Coding> GetActiveUsers();


    }
    public class CodingRepository : Repository<Coding>, ICodingRepository
    {
        private readonly DbContext _db;
        public CodingRepository(DbContext dbContext) : base(dbContext)
        {
            this._db = (this._db ?? (ApplicationContext)_db);
        }

        public IList<Coding> GetActiveUsers()
        {
            var users = GetAll().ToList();
            return users;
        }
    }
}
