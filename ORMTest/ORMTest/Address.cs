using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ORMTest
{
    public class Address
    {
        [Key]
        public int FactoryID { get; set;}
        public String HouseNumber { get; set; }
        public String Street { get; set; }
        public String Town { get; set; }
        public String PostCode { get; set; }

    }
}
