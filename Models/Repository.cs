using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zabolotnyi_zpi_zp_92_lab_kpi_3.Models
{
    public static class Repository
    {
        private static List<Player> players = new List<Player>();
        public static IEnumerable<Player> Players 
        {  
            get {return players; }
        }
        public static void AddPlayers(Player player)
        {
            players.Add(player);
        }
    }
}
