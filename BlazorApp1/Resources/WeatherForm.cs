using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Resources
{
    public class WeatherForm
    {
        [Required]
        public DateTime Date { get; set; }

        [Required]
        [Range(0, 99999, ErrorMessage = "Invalid zip code")]
        public int ZipCode { get; set; } = 0;

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

    }
}
