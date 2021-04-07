using System;

namespace ExpenseBudget.Models
{
    public class DbContextOptionsBuilder
    {
        public bool IsConfigured { get; internal set; }

        internal void UseSqlServer(string v)
        {
            throw new NotImplementedException();
        }
    }
}