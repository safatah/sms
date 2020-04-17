using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HappyHelper.Models
{
    public class InventoryTracker
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [Display(Name = "Last Restocked")]
        [DataType(DataType.Date)]
        public DateTime RestockDate { get; set; }
        public string InStock { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}