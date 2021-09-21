using LineamientosGobApisEPM.Domain.Entities;
using LineamientosGobApisEPM.Domain.Ports;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LineamientosGobApisEPM.Domain.Services
{
    public class SuccessResponseService : ISuccessResponseService
    {
        async Task<SuccessEntity> ISuccessResponseService.GetSuccessResponse()
        {
            return await Task.Run(()=>new SuccessEntity("F"));
        }
    }
}
