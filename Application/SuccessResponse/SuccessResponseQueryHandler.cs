using AutoMapper;
using LineamientosGobApisEPM.Domain.Entities;
using LineamientosGobApisEPM.Domain.Ports;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LineamientosGobApisEPM.Application.SuccessResponse
{
    public class SuccessResponseQueryHandler : IRequestHandler<SuccessResponseQuery, SuccessResponseDto>
    {
        private readonly ISuccessResponseService _ISuccessResponseService;
        private readonly IMapper _Mapper;

        public SuccessResponseQueryHandler(IMapper mapper, ISuccessResponseService successResponseService)
        {
            _ISuccessResponseService = successResponseService;
            _Mapper = mapper;
        }

        public async Task<SuccessResponseDto> Handle(SuccessResponseQuery request, CancellationToken cancellationToken)
        {
            _ = request ?? throw new ArgumentNullException("request", "request object needed to handle this task");
            var response = await _ISuccessResponseService.GetSuccessResponse();
            return _Mapper.Map<SuccessResponseDto>(response);
        }
    }
}
