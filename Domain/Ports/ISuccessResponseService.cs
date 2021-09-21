using LineamientosGobApisEPM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LineamientosGobApisEPM.Domain.Ports
{
    public interface ISuccessResponseService
    {
        Task<SuccessEntity> GetSuccessResponse();
    }
}
