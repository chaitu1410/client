using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace client.Data
{
    public class SaleReturn
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Customer Name is required.")]
        [StringLength(100)]
        [DisplayName("Name Of Customer")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Please Enter Valid Amount of Transaction.")]
        [Column(TypeName = "decimal(10, 2)")]
        [DisplayName("Amount Of Transaction")]
        public decimal Amount { get; set; }

        [DisplayName("Date Of Sale Return")]
        public DateTime Date { get; set; }
    }
}
