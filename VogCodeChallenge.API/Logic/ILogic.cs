using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Logic
{
    public interface ILogic<T>
    {
        public List<T> GetEmployeeList();   
    }
}
