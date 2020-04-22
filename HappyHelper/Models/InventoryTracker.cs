using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HappyHelper.Models
{
    public class CurrentDateAttribute : ValidationAttribute //checks that date entered (for RestockDate) is before or = current date
    {
        public override bool IsValid(object value)
        {
            DateTime n = Convert.ToDateTime(value);
            return n <= DateTime.Now;
        }
    }
    public class InventoryTracker
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 2)]
        [Required(ErrorMessage = "Please enter a valid product name")]
        public string Title { get; set; }

        [Display(Name = "Last Restocked")]
        [CurrentDate(ErrorMessage = "Date entered must be either be equal or prior to today's date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime RestockDate { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid number")]
        [Required]
        public string InStock { get; set; }

        [Range(1, 1000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Required(ErrorMessage = "Please enter valid product price")]
        public decimal Price { get; set; }


        public string UserId { get; set; }
    }
}