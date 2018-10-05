using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FC.Data
{
    public class Folder
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
