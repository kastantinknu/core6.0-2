using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zabolotnyi_zpi_zp_92_lab_kpi_3.Models;

namespace core6._0_2.Models
{
    interface IPlayerRepository
    {
        IQueryable<Player> Players { get; }
    }
}
