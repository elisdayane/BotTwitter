using AutoMapper;
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
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]

    public class TwitterController : ControllerBase
    {

        private ITwitterService service;
        private IMapper mapper;

        public TwitterController(ITwitterService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }


        [HttpPost]
        public ActionResult<TagDTO> Post(TagDTO value)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            
            return Ok();
        }


    }
}
