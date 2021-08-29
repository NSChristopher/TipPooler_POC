using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipPooler_POC.DataModels
{
    class SalesJournal
    {
        [Key]
        public int ListId { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public int DepartmentId { get; set; }
        public DateTime Time { get; set; }
        public double Sale { get; set; }
    }
}
