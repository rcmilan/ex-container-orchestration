using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Services;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunityController : ControllerBase
    {
        private readonly ICommunityService _service;

        public CommunityController(ICommunityService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ICollection<Community>> Get()
        {
            return await _service.Get();
        }

        [HttpPost]
        public async Task<Community> Post()
        {
            Community community = new()
            {
                Title = "Eu odeio acordar cedo",
                Description = "DescriçãoDescriçãoDescriçãoDescrição",
                Forums = new List<Forum>
                {
                    new Forum
                    {
                        Title = "Tópico 1",
                        Posts = new List<Post>
                        {
                            new Post
                            {
                                Content ="BlaBlaBlaBlaBla"
                            },
                            new Post
                            {
                                Content ="hueheuheue br"
                            }
                        }
                    }
                }
            };

            return await _service.Add(community);
        }
    }
}
