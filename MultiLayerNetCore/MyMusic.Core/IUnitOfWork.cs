using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMusic.Core.Repositories;

namespace MyMusic.Core

{
    public interface IUnitOfWork : IDisposable
    {
        IMusicRepository Music { get; }
        IArtistRepository Artist { get; }
        Task<int> CommitAsync();
    }
}
