using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger.DAL.Entities.Abstract
{
    public interface IBaseEntity
    {
        int ID
        {
            get;
            set;
        }
        DateTime Created
        {
            get; set;
        }
        DateTime? Updated
        {
            get; set;
        }
        DateTime? Deleted
        {
            get; set;
        }
    }
}
