using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace client.Data
{
    class Borrow
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Valid Amount of Transaction.")]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage ="Customer Name is required.")]
        [StringLength(100)]
        public string CustomerName { get; set; }

        [Timestamp]
        public DateTime Date { get; set; }

        public bool IsReturned { get; set; } = false;

        public DateTime ReturnDate { get; set; }
    }
}
