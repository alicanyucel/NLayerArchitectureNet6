using Entity.Model;
using RepositoryLayer.Constract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.EfCore
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneBook(Book book)=>CreateOneBook(book);
       

        public void DeleteOneBook(Book book)=>DeleteOneBook(book);
      

        public IQueryable<Book> GetAllBooks(bool trackChanges)=>FindAll(trackChanges).OrderBy(b=>b.Id);


        public Book GetBookById(int Id, bool trackChanges) => (Book)FindByCondition(b => b.Id.Equals(Id), trackChanges);
        

        public void UpdateOneBook(Book book)=>Update(book);
       
    }
}
