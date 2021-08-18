using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipPooler_POC.DataModels
{
    class ShiftList
    {
        [Key]
        public int ListId { get; set; }
        public List<Shift> ShiftLists { get; set; }
    }
}
