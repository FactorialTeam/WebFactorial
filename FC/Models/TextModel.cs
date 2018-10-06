using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FC.Models
{
    public class TextModel
    {
        public int Id { get; set; }
        public string TextContent { get; set; }
        public bool Status { get; set; }
    }
    public class TextViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? FolderId { get; set; }
        public bool Status { get; set; }
        public List<QuestionModel> Questions { get; set; }
    }
    public class SaveQuestionModel
    {
        public int TextId { get; set; }
        public string Folder { get; set; }
        public List<QuestionModel> Questions { get; set; }
    }
}
