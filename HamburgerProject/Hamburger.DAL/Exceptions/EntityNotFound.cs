using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger.DAL.Exceptions
{
    public class EntityNotFound : Exception
    {
        public EntityNotFound() : base() { }
        public EntityNotFound(string? message) : base(message) { }
        public EntityNotFound(string? message, Exception? innerException) : base(message, innerException) { }
    }
}
