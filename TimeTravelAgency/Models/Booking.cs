using System.ComponentModel.DataAnnotations;

namespace TimeTravelAgency.Models;

public class Booking
{
    [Required]
    public int DestinationId { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime TravelDate { get; set; }

    [Range(1, 10)]
    public int Travelers { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; } = "";
}
