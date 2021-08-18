using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipPooler_POC.DataModels
{
    class TipJournal
    {
        [Key]
        public int UserId { get; set; }
        public DateTime Time { get; set; }
        public double Tip { get; set; }
    }
}
