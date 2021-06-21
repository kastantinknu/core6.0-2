using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zabolotnyi_zpi_zp_92_lab_kpi_3.Models
{
    public class Game
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Team[] Teams { get; set; }
        public int[] Score { get; set; }

    }
}
