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
        [DisplayName("Borrowing Balance")]
        public decimal BorrowingBalanceAmount { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        [DisplayName("Credit Deposit")]
        public decimal CreditDepositAmount { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        [DisplayName("Total Sale")]
        public decimal TotalSaleAmount { get; set; }

        [DisplayName("Date")]
        public DateTime Date { get; set; }

        public List<string> Columns = new List<string> { "Cash", "Sale Return", "Card", "Online", "Extras", "Borrowing Balance", "Credit Deposit", "Total Sale"};

        public string GetByString(string columnName)
        {
            switch (columnName)
            {
                case "Cash":
                    return this.CashAmount.ToString();

                case "Sale Return":
                    return this.SaleReturnAmount.ToString();

                case "Card":
                    return this.CardAmount.ToString();

                case "Online":
                    return this.OnlineAmount.ToString();

                case "Extras":
                    return this.ExtraAmount.ToString();

                case "Borrowing Balance":
                    return this.BorrowingBalanceAmount.ToString();

                case "Credit Deposit":
                    return this.CreditDepositAmount.ToString();

                case "Total Sale":
                    return this.TotalSaleAmount.ToString();
                default:
                    return "";
            }
        }

    }
}
