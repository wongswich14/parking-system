using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specifications
{
    public abstract class Specification<T>
    {
        public abstract Expression<Func<T, bool>> ToExpression();

        public Func<T, bool> ToFunc()
        {
            return ToExpression().Compile();
        }
    }
}
