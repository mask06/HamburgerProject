using Hamburger.DAL.Context;
using Hamburger.DAL.Entities.Concrete;
using Hamburger.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger.DAL.Repositories.Concrete
{
    public class ExtraFoodRepository :Repository<ExtraFood>, IExtraFoodRepository
    {
        
            private HamburgerDbContext _dbcontext;
            private bool disposed = false;
            public ExtraFoodRepository(HamburgerDbContext context) : base(context)
            {
                _dbcontext = context;
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!this.disposed)
                {
                    if (disposing)
                    {
                        _dbcontext.Dispose();
                    }
                }
                this.disposed = true;
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        
    }
}
