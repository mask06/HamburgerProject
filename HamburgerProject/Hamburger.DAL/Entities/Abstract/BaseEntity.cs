using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger.DAL.Entities.Abstract
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int ID
        {
            get;
            set;
        }
        public DateTime Created
        {
            get;
            set;
        }= DateTime.Now;
        public DateTime? Updated
        {
            get;
            set;
        }
        public DateTime? Deleted
        {
            get;
            set;
        }
    }
}
