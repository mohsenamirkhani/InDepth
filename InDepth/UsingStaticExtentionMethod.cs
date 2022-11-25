using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using static System.Linq.Queryable;

namespace InDepth
{
    public class UsingStaticExtentionMethod
    {
        public UsingStaticExtentionMethod()
        {
            var query = new[] { "a", "bc", "d" }.AsQueryable();

            Expression<Func<string, bool>> expr = x => x.Length > 1;

            Func<string, bool> func = x => x.Length > 1;

            var queryable = query.Where(expr);

            // this is valid if we use regular using on System.Linq
            //var q = query.Where(func);
        }
    }
}
