using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WorkScheduleSolution.Entities
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Street { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string City { get; set; }

        [Column(TypeName = "nchar(2)")]
        public string Province { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? Contact { get; set; }

        [Column(TypeName = "char(12)")]
        public int Phone { get; set; }

        [Column(TypeName = "bit")]
        public bool Active { get; set; }

        //one Location to Many PlacementContracts

        public ICollection<PlacementContract> PlacementContracts  { get; set; }
    }
}
