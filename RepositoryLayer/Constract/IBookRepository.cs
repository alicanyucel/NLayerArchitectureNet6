using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Constract
{
    public interface IBookRepository:IRepositoryBase<Book>
    {
        IQueryable<Book> GetAllBooks(bool trackChanges);
        IQueryable<Book> GetBookById(int Id,bool trackChanges);
        void CreateOneBook(Book book);
        void UpdateOneBook(Book book);
        void DeleteOneBook(Book book);
    }
}
