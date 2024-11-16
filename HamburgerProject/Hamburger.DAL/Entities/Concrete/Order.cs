using Hamburger.DAL.Entities.Abstract;
using Hamburger.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger.DAL.Entities.Concrete
{
    public class Order : BaseEntity
    {
        public int MenuID
        {
            get;
            set;
        }
        public OrderSize Size
        {
            get; set;
        }
        public int ExtraFoodID
        {
            get;
            set;
        }
        public int OrderCount
        {
            get;
            set;
        }
        public ExtraFood ExtraFood
        {
            get;
            set;
        }
        public Menu Menu
        {
            get;
            set;
        }
    }
}
