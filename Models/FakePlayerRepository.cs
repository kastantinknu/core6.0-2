using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zabolotnyi_zpi_zp_92_lab_kpi_3.Models;

namespace zabolotnyi_zpi_zp_92_lab_kpi_3.Models
{
    public class FakePlayerRepository : IPlayerRepository
    {
        public IQueryable<Player> Players => new List<Player>{
        new Player{Id=1,Name="Karlo",Position="Goalkeeper", RedCard=false},
        new Player{Id=2,Name="Pablo",Position="Defender", RedCard=false},
        new Player{Id=3,Name="Raul",Position="Midfielder", RedCard=false},
        }.AsQueryable<Player>();
    }
}
