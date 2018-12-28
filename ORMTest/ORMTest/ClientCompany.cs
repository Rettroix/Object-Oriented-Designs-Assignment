﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ORMTest
{

    public class ClientCompany
    {
        public ClientCompany()
        {
            Jobs = new List<Job>();
        }

        [Key]
        public int PrimaryKey { get; set; }
        [MinLength(3), MaxLength(30)]
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Job> Jobs { get; set; }


    }
}