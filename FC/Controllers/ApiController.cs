using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FC.DataAccess.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FC.Controllers
{
    [Produces("application/json")]
    [Route("api/Api")]
    public class ApiController : Controller
    {
        protected readonly IUnitOfWork UnitOfWork;

        public ApiController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
    }
}