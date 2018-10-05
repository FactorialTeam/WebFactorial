using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FC.Data
{
    public class TextQuestion
    {
        public int Id { get; set; }
        public int TextId { get; set; }
        public virtual Text Text { get; set; }
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public bool Status { get; set; }

    }
}
