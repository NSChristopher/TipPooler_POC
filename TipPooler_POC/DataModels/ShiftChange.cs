using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipPooler_POC.DataModels
{
    class ShiftChange
    {
        [Key]
        public int ListID { get; set; }
        public TimeSpan ShiftChanges { get; set; }
    }
}
