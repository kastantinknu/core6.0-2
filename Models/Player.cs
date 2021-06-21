using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace zabolotnyi_zpi_zp_92_lab_kpi_3.Models
{
    public class Player
    {
        [Required()]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter player's name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter player's position")]
        public string Position { get; set; }
        [Required(ErrorMessage = "Please specify RedCard")]
        public bool? RedCard { get; set; }

    }
}
