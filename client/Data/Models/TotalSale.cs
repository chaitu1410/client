using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace client.Data
{
    public class TotalSale
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        [DisplayName("Cash")]
        public decimal CashAmount { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        [DisplayName("Sale Return")]
        public decimal SaleReturnAmount { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        [DisplayName("Card Payments")]
        public decimal CardAmount { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        [DisplayName("Online Payments")]
        public decimal OnlineAmount { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        [DisplayName("Extras")]
        public decimal ExtraAmount { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        [DisplayName("Total Sale")]
        public decimal TotalSaleAmount { get; set; }

        [DisplayName("Date")]
        public DateTime Date { get; set; }

    }
}
