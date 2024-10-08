using System.Data.Entity;

namespace ExpenseTracker.Models
{
    public class ExpenseContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
    }
}
