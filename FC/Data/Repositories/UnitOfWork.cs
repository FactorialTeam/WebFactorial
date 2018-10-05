using FC.Data;
using FC.Data.Repositories;
using FC.Data.Repositories.Interfaces;
using FC.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FC.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public UnitOfWork(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        private readonly ApplicationDbContext DbContext;
        public int Save()
        {
            return DbContext.SaveChanges();
        }
        public async Task<int> SaveAsync()
        {
            return await DbContext.SaveChangesAsync();
        }
        ITextRepository _TextRepository;
        public ITextRepository TextRepository => _TextRepository ?? (_TextRepository = new TextRepository(DbContext));

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    DbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
