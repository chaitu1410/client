using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace client.Data
{
    public class Borrow
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Valid Amount of Transaction.")]
        [Column(TypeName = "decimal(10, 2)")]
        [DisplayName("Borrowed Amount")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage ="Customer Name is required.")]
        [StringLength(100)]
        [DisplayName("Name Of Customer")]
        public string CustomerName { get; set; }

        [DisplayName("Date")]
        public DateTime Date { get; set; }

        [DisplayName("Borrowed Deposit")]
        public bool IsReturned { get; set; } = false;

        [DisplayName("Date Of Deposite")]
        public DateTime ReturnDate { get; set; }

        public static List<string> PdfColumnsName = new List<string> { "Customer Name", "Amount" };

        public string GetByString(string columnName)
        {
            switch (columnName)
            {
                case "Customer Name":
                    return this.CustomerName.ToString();
                case "Amount":
                    return this.Amount.ToString();
                default:
                    return "";
            }
        }
    }

   
}
