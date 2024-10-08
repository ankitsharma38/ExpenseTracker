using System;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string Description { get; set; }
    }
}
