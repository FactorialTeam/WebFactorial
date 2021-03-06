﻿using FC.Data.Repositories.Interfaces;
using FC.Models;
using Microsoft.EntityFrameworkCore;
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
        public async Task<List<QuestionModel>> GetQuestions(int textID)
        {
            var lst = await (from o in DbContext.TextQuestions
                             where o.TextId == textID
                             select new QuestionModel
                             {
                                 Id = o.Id,
                                 Text = o.Question.Text
                             }).ToListAsync();
            return lst;
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
        public async Task<List<TextViewModel>> GetTextBy(int folderID)
        {
            var lst = await (from t in DbContext.Texts
                             where t.FolderId == folderID
                             select new TextViewModel
                             {
                                 Id = t.Id,
                                 Title = t.TextContent,
                                 FolderId = t.FolderId,
                                 Questions = t.TextQuestions.Select(q => new QuestionModel
                                 {
                                     Id = q.QuestionId,
                                     Text = q.Question.Text
                                 }).ToList()
                             }).ToListAsync();
            return lst;
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
