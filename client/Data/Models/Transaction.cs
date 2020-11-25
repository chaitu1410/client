using client.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace client.Data
{
    public class Transaction
    {
        [Key]
        [DisplayName("Id")]
        public int TransactionId { get; set; }

        [DisplayName("Amount")]
        [Required(ErrorMessage = "Please Enter Valid Amount of Transaction.")]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        [DisplayName("Extras")]
        public double Extras { get; set; } = 0.0;

        [Required(ErrorMessage = "Please Select Valid Payment Method.")]
        [DisplayName("Payment Method")]
        public PaymentMethods PaymentMethod { get; set; } = PaymentMethods.Card;

        [DisplayName("Date")]
        public DateTime Date { get; set; }
    }
}
