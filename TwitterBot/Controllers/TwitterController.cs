using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TwitterBot.DTO;
using TwitterBot.Service;
using System.Net.Http;

namespace TwitterBot.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("api/[controller]")]

    public class TwitterController : ControllerBase
    {

        private ITwitterService _service;
        private IMapper mapper;

        public TwitterController(ITwitterService service, IMapper mapper)
        {
            this._service = service;
            this.mapper = mapper;
        }


        //[HttpPost]
        [HttpPost("search")]
        public ActionResult<RespostaDTO> search()
        {
           
            //var lista = _service.SearchTag(Tag);
            return Ok();
        }




    }
}
