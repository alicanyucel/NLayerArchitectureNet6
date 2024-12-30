using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Constract;
using RepositoryLayer.EfCore;

namespace NLayerWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        public BooksController(RepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
    }
}
