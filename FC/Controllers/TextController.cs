using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FC.DataAccess.Repositories.Interfaces;
using FC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FC.Controllers
{
    [Produces("application/json")]
    [Route("api/Text")]
    public class TextController : ApiController
    {
        public TextController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        [HttpPost("addtext")]
        public async Task<object> AddText([FromBody] TextModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await UnitOfWork.TextRepository.AddText(model);
                    return Json(new { success = true });
                }
                return Json(new { success = false, error = "Model have required fields" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, error = ex.Message });
            }

        }
        [HttpPost("addfolder")]
        public async Task<object> AddFolder([FromBody] FolderModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await UnitOfWork.TextRepository.AddFolder(model);
                    return Json(new { success = true });
                }
                return Json(new { success = false, error = "Model have required fields" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, error = ex.Message });
            }

        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAllFolders()
        {
            var folders = await UnitOfWork.TextRepository.GetAllFolders();
            return Json(new { success = true, result = folders });
        }
        [HttpPost("addquestions")]
        public async Task<object> AddQuestions([FromBody] List<QuestionModel> model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await UnitOfWork.TextRepository.AddQuestions(model);
                    return Json(new { success = true });
                }
                return Json(new { success = false, error = "Model have required fields" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, error = ex.Message });
            }

        }
    }
}