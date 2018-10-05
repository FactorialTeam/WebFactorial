using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FC.Data
{
    public class  Text
    {
        public Text()
        {
            TextQuestions = new System.Collections.ObjectModel.Collection<TextQuestion>();
        }
        public int Id { get; set; }
        [Required]
        public string TextContent { get; set; }
        public bool Status { get; set; }
        public int? FolderId { get; set; }
        public virtual Folder Folder { get; set; }
        public ICollection<TextQuestion> TextQuestions { get; set; }
    }
}
