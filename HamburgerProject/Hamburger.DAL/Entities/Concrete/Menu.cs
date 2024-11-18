using Hamburger.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger.DAL.Entities.Concrete
{
    public class Menu : BaseEntity
    {
        public string Name
        {
            get;
            set;
        }
        public Decimal Price
        {
            get;
            set;
        }
        public ICollection<Order> Orders
        {
            get;
            set;
        }
        public byte[]? Picture { get; set; } = null!;
    }
}
