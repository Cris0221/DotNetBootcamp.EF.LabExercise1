using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Schedule
    {
        [Key]
        public int ScheduleID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Day { get; set; }


        [Column(TypeName = "money")]
        public decimal HourlyWage { get; set; }


        [Column(TypeName = "bit")]
        public bool OverTime { get; set; }

        //FK
        public int ShiftID { get; set; }
        public Shift Shift { get; set; }
        //FK
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }

    }
}
