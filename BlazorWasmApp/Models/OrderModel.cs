﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BlazorWasmApp.Models
{
    public class OrderModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "You need to keep the name to max of 20 characters")]
        [MinLength(3, ErrorMessage = "You need to enter at least 3 characters for order name")]
        [Display(Name = "Name for the Order")]
        public string OrderName { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "You need to select a meal from the list")]
        [Display(Name = "Meal")]
        public int FoodId { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "You can order maximum of 10 meals at once")]
        public int Quantity { get; set; }

        [DisplayFormat(DataFormatString = ("{0:C}"), ApplyFormatInEditMode = true)]
        public decimal Total { get; set; }

    }
}
