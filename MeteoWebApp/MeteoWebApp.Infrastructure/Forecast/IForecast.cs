﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoWebApp.Infrastructure.Forecast
{
    public interface IForecast
    {
        int             Id                      { get; set; }
        int             Temperature             { get; set; }
        int             GeneralState            { get; set; }
        int             WindDirection           { get; set; }
        int             WindSpeed               { get; set; }
        int             RainChance              { get; set; }
        string          GeneralStateImageUrl    { get; set; }
        string          GeneralStateCaption     { get; set; }
        string          WindDirectionImageUrl   { get; set; }
        DateTimeOffset  Date                    { get; set; }
    }
}
