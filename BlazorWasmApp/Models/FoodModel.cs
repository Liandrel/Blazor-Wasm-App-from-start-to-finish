using System.ComponentModel.DataAnnotations;

namespace BlazorWasmApp.Models
{
    public class FoodModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        [DisplayFormat(DataFormatString = ("{0:C}"), ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }

    }
}
