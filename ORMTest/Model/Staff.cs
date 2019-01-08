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
    public class Staff
    {
        [Key]
        public int StaffID { get; set;}
        public String StaffName { get; set; }
        public String StaffRole { get; set; }
        public String JobDate { get; set; }
    }
}
