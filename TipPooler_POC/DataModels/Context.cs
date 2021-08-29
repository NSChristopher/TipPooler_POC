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
        public DbSet<Employee> Employees { get; set; }
        public DbSet<SalesJournal> SalesJournals { get; set; }
        public DbSet<ShiftList> Shifts { get; set; }
        public DbSet<ShiftChange> ShiftChanges { get; set; }
        public DbSet<TipJournal> TipJournals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=db;Trusted_Connection=True;");
        }

    }
}
