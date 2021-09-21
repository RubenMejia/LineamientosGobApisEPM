using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace LineamientosGobApisEPM.Application.SuccessResponse
{
    public class SuccessResponseQuery : IRequest<SuccessResponseDto>
    {
        public SuccessResponseQuery(){}
    }
}
