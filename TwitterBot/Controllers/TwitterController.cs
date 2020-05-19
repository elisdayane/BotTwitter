using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterBot.DTO;
using TwitterBot.Service;

namespace TwitterBot.Controllers
{
    [Produces("application/json")]
    [ApiController]
    //[ApiVersion("1.0")]
    //[Route("api/v{version:apiVersion}/[controller]")]

    public class TwitterController : ControllerBase
    {

        private ITwitterService _service;
        private IMapper mapper;

        public TwitterController(ITwitterService service, IMapper mapper)
        {
            this._service = service;
            this.mapper = mapper;
        }



        [HttpPost("search")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult search(string Tag)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var lista = _service.SearchTag(Tag);

            //teste
            return Ok(Tag);
        }


    }
}
