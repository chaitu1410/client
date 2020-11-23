using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace client.Data
{
    class TotalSale
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal CashAmount { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal SaleReturnAmount { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal CardAmount { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal ExtraAmount { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotalSaleAmount { get; set; }

        public DateTime Date { get; set; }

    }
}
