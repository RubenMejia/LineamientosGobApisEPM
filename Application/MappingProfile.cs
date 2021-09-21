using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LineamientosGobApisEPM.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<Domain.Entities.SuccessEntity, LineamientosGobApisEPM.Application.SuccessResponse.SuccessResponseDto>();
            CreateMap<LineamientosGobApisEPM.Application.SuccessResponse.SuccessResponseDto, Domain.Entities.SuccessEntity>();
        }
    }
}
