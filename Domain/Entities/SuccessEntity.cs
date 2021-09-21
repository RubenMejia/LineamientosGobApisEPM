using System;
using System.Collections.Generic;
using System.Text;

namespace LineamientosGobApisEPM.Domain.Entities
{
    public class SuccessEntity
    {
        public SuccessEntity(string data)
        {
            Data = data;
        }
        public string Data { get; set; }

    }
}
