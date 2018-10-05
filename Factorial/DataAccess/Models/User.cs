﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess
{
    public class User : IdentityUser<int>, IBaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public bool Deleted { get; set; }
        public bool IsActive { get; set; }
    }
}
