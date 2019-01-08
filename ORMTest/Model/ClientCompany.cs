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

    public class ClientCompany
    {
        public ClientCompany()
        {
            Jobs = new List<Job>();
        }

        [Key]
        public int ClientID { get; set; }
        [MinLength(3), MaxLength(30)]
        public string ClientName { get; set; }
        public string Email { get; set; }
        //[ForeignKey("StandardRefId")]
        public virtual ICollection<Job> Jobs { get; set; }


    }
}
