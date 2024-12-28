using RepositoryLayer.Constract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.EfCore
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IBookRepository> _bookRepository;
        private readonly RepositoryContext _context;
        public RepositoryManager(RepositoryContext context)
        {   
          _context = context;
          _bookRepository=new Lazy<IBookRepository>(() => new BookRepository(_context));

        }
        public IBookRepository BookRepository => _bookRepository.Value;
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
