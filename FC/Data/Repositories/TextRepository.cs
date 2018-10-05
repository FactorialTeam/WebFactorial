using FC.Data.Repositories.Interfaces;
using FC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FC.Data.Repositories
{
    public class TextRepository : BaseRepository, ITextRepository
    {
        public TextRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
        public async Task AddText(TextModel model)
        {
            Text text = new Text();
            text.TextContent = model.TextContent;
            DbContext.Texts.Add(text);
            await DbContext.SaveChangesAsync();
        }
        public async Task AddFolder(FolderModel model)
        {
            Folder folder = new Folder();
            folder.Title = model.Title;
            DbContext.Folders.Add(folder);
            await DbContext.SaveChangesAsync();
        }
        public async Task<List<FolderModel>> GetAllFolders()
        {
            var folders = await (from o in DbContext.Folders
                                select new FolderModel
                                {
                                    Id = o.Id,
                                    Title = o.Title,
                                }).ToListAsync();
            return folders;
        }
        public async Task AddQuestions(List<QuestionModel> model)
        {
            foreach (var item in model)
            {
                var question = new Question();
                question.Text = item.Text;
                await DbContext.Questions.AddAsync(question);
                await DbContext.SaveChangesAsync();
            }
        }
    }
}
