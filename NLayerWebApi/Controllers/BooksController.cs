using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.EfCore;

namespace NLayerWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly RepositoryManager _repositoryManager;

        public BooksController(RepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
    }
}
