using FC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FC.Data.Repositories.Interfaces
{
    public interface ITextRepository
    {
        Task AddText(TextModel model);
        Task AddFolder(FolderModel model);
        Task<List<FolderModel>> GetAllFolders();
        Task AddQuestions(List<QuestionModel> model);
    }
}
