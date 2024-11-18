using Hamburger.DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger.DAL.Repositories.Abstract
{
    public interface IOrderRepository : IRepository<Order>, IDisposable
    {

    }
}
