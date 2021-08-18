using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipPooler_POC.DataModels
{
    class Context: DbContext
    {
        DbSet<Employee> Employees { get; set; }
        DbSet<SalesJournal> SalesJournals { get; set; }
        DbSet<Shift> Shifts { get; set; }
        DbSet<ShiftChange> ShiftChanges { get; set; }
        DbSet<ShiftList> ShiftLists { get; set; }
        DbSet<TipJournal> TipJournals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb);Database=db;Trusted_Connection=True;");
        }

    }
}
