using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factorial.DataAccess
{
    public class BaseEntity : IBaseEntity
    {
        public bool Deleted { get; set; }
    }

    public interface IBaseEntity
    {
        bool Deleted { get; set; }
    }
}
