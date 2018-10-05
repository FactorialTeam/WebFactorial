using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FC.Data
{
    public class  Text
    {
        public int Id { get; set; }
        [Required]
        public string TextContent { get; set; }
        public bool Status { get; set; }
    }
}
