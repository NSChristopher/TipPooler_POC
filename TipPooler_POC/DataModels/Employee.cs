using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipPooler_POC.DataModels
{
    class Employee
    {
        [Key]
        public int UserId { get; set; }
        public String UserName { get; set; }
        public String UserType { get; set; }
    }
}
