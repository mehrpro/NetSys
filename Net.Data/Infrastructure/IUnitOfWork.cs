using Microsoft.EntityFrameworkCore;
using Net.Data.Repositoies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Data.Infrastructure
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        //1-Begin TransAction  2-Commit(SaveChange) 3-RollBack
       // ImportExportRepository ImportExportRepository { get; } //Read Only

        CodingRepository CodingRepository { get; }
        void Commit();
        Task<int> CommitAsync();


    }
}
