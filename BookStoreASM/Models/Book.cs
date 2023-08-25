using System.ComponentModel.DataAnnotations;

namespace BookStoreASM.Models
{
    public class Book
    {
        public string? Id { get; set; }

        [Required]

        public string? Title { get; set; }

        [Required, MaxLength(100)]

        public string Description { get; set; }

        public string Language { get; set; }

        [Required, MaxLength(13)]

        public string ISBN { get; set; }

        [Required,
         DataType(DataType.Date),
         Display(Name = "Date Published")]

        public string DatePublished { get; set; }

        [Required, DataType(DataType.Currency)]

        public int Price { get; set; }

        [Required]

        public string Author { get; set; }

        [Display(Name = "Image URL")]

        public string ImageUrl { get; set; }

    }
}
