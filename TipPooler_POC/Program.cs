using System;
using System.Linq;
using TipPooler_POC.DataModels;

namespace TipPooler_POC
{
    class Program
    {
        static void Main(string[] args)
        {
            using Context myContext = new Context();

            var employees = myContext
                .Employees
                .Where(e=>e.UserId > 0)
                .ToList();

            foreach (var row in employees)
            {
                Console.WriteLine(row.UserName);
            }
        }
    }
}
