//KF7012 Task 3 Implementation
//Date: December 2018
//Names: Elliot Anderson, Adam Cook
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Job
    {
        public Job()
        {
            FactoryLocation = new List<Address>();
        }

        [Key]
        public int JobID { get; set; }
        [Required]
        public String MachineDescription { get; set; }
        [Required]
        public String FaultDescription { get; set; }
        public int JobUrgency { get; set; }
        public int MachineComplexity { get; set; }

        public List<Address> FactoryLocation { get; set; }
        public virtual ICollection<Staff> AssignedStaff { get; set; }

    }
}
