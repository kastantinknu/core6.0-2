using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zabolotnyi_zpi_zp_92_lab_kpi_3.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Player[] players { get; set; }
    }
}
