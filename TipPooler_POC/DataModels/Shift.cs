using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipPooler_POC.Enums;

namespace TipPooler_POC.DataModels
{
    class Shift
    {
        [Key]
        public int UserId { get; set; }
        public UserType UserType { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
    }
}
