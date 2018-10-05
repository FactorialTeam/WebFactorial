using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FC.Data
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
