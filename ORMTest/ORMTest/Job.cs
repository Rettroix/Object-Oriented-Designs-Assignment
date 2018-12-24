using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ORMTest
{
    public class Job
    {
        public Job()
        {
            FactoryLocation = new List<Address>();
        }

        [Key]
        public int PrimaryKey { get; set; }
        [Required]
        public String MachineDescription { get; set; }
        [Required]
        public String FaultDescription { get; set; }
        public List<Address> FactoryLocation { get; set; }
        public int JobUrgency { get; set; }
        public int MachineComplexity { get; set; }
    }
}
