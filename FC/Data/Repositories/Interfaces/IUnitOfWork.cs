using FC.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FC.DataAccess.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ITextRepository TextRepository { get; }
    }
}