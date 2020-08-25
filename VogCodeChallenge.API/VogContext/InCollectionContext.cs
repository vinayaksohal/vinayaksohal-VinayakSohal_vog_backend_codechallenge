using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VogCodeChallenge.API.Logic;
using VogCodeChallenge.API.Models;
using VogCodeChallenge.API.VogContext;

namespace VogCodeChallenge.API.VogContext
{
    public class InCollectionContext<T> : IDataRepository<T>
    {
        private readonly ILogic<T> _ILogic;
        public InCollectionContext(ILogic<T> ILogic)
        {
            _ILogic = ILogic;
        }
        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            return _ILogic.GetEmployeeList();
        }

        public IList<T> ListAll(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            return _ILogic.GetEmployeeList().AsQueryable().Where(where).ToList();
        }
    }
}
