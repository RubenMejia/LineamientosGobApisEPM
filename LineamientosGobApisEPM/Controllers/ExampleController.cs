using LineamientosGobApisEPM.Application.SuccessResponse;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LineamientosGobApisEPM.Controllers
{
    [ApiController]
    [Route("[example]")]
    public class ExampleController : ControllerBase
    {

        private readonly IMediator _Mediator;

        public ExampleController(IMediator mediator)
        {
            _Mediator = mediator;
        }

        /// <summary>
        /// Return one Success Response
        /// </summary>
        [HttpGet("/")]
        public async Task<SuccessResponseDto> GetAsync()
        {
            return await _Mediator.Send(new SuccessResponseQuery());
        }

    }
}
