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

        private ITwitterService service;
        private IMapper mapper;

        public TwitterController(ITwitterService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }



        [HttpPost("tag")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<TagDTO> Post(TagDTO value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            //teste request
            
            return Ok(value);
        }


    }
}
