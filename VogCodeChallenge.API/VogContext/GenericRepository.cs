using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.VogContext
{

    public class GenericRepository<T> : IDataRepository<T> where T : class
    {
        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            IEnumerable<T> list;
            using (var context = new VogCodeContext())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                list = dbQuery
                    .AsNoTracking()
                    .ToList<T>();
            }
            return list;
        }

        public IList<T> ListAll(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            using (var context = new VogCodeContext())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                list = dbQuery
                    .AsNoTracking()
                    .Where(where)
                    .ToList<T>();
            }
            return list;
        }
    }
}
