using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace client.Data
{
    class SaleReturn
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Valid Amount of Transaction.")]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }

        [Timestamp]
        public DateTime Date { get; set; }
    }
}
