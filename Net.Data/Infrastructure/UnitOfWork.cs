using Microsoft.EntityFrameworkCore;
using Net.Data.Repositoies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Data.Infrastructure
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : DbContext, new()

    {

        #region Fileds
        protected readonly DbContext db;

        #endregion

        #region Ctor
        public UnitOfWork()
        {
            db = new TContext();
        }

        #endregion

        #region Implement

        public void Commit()
        {
            db.SaveChanges();
        }

        public Task<int> CommitAsync()
        {
            return db.SaveChangesAsync();
        }

        #endregion

        #region Repositories
        private CodingRepository _codingRepository;
        public CodingRepository CodingRepository
        {
            get
            {
                if (_codingRepository == null)
                {
                    _codingRepository = new CodingRepository(db);
                }
                return _codingRepository;
            }
        }
        #endregion

        #region Dispose

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        #endregion

    }
}
