using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class PlacementContract
    {
        [Key]
        public int PlacementContractID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        //FK

        public int LocationID { get; set; }
        public Location Location { get; set; }

        //one PlacementContracts to many Shifts
        public ICollection<Shift> Shifts { get; set; }


    }
}
