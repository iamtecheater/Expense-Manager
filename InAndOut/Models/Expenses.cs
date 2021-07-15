﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Expenses
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Expenses")]
        [Required]
        public string ExpenseName { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public int Amount { get; set; }
        [DisplayName("Expense Type")]
        public int ExpenseTypeIds { get; set; }
        public virtual ExpenseType ExpenseType { get; set; }
        
    }
}
