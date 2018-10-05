using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FC.Models
{
    public class TextQuestionModel
    {
        public int Id { get; set; }
        public int TextId { get; set; }
        public TextModel Text { get; set; }
        public int QuestionId { get; set; }
        public QuestionModel Question { get; set; }
        public bool Status { get; set; }
    }
}
