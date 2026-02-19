namespace TimeTravelAgency.Models;

public class Destination
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Era { get; set; } = "";
    public string ShortDescription { get; set; } = "";
    public string LongDescription { get; set; } = "";
    public string ImageUrl { get; set; } = "";
    public decimal PriceFrom { get; set; }
}
