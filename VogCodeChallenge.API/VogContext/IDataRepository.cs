using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.VogContext
{
    public interface IDataRepository<T>
    {

        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);
        public IList<T> ListAll(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties);
    }
}
