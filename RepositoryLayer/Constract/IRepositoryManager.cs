using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Constract
{
    public interface IRepositoryManager
    {
        IBookRepository BookRepository { get; }
        void Save();
    }
}
