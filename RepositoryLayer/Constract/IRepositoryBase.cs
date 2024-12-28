using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Constract
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable FindByCondition(Expression<Func<T, bool>> expressinon, bool condition);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
