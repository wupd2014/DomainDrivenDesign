using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Data.Infrastructure
{
    public class DatabaseFactory : Disposable,IDatabaseFactory
    {
        private CodeFirstDbContext dataContext;
        public CodeFirstDbContext Get()
        {
            return dataContext ?? (dataContext = new CodeFirstDbContext());
        }

        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }

    }
}
