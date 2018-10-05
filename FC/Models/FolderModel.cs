using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FC.Models
{
    public class FolderModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

    }
    public class FileModel
    {
        public int FolderId { get; set; }
    }
}
