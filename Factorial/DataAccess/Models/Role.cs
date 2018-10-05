using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial.DataAccess
{
    public class Role : IdentityRole<int>
    {
        public Role()
        {
        }
        public Role(string roleName) : base(roleName)
        {
        }
    }
}
