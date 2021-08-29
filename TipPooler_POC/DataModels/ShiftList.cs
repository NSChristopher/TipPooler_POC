using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipPooler_POC.Enums;

namespace TipPooler_POC.DataModels
{
    class ShiftList
    {
        [Key]
        public int ListId { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
