using TimeTravelAgency.Models;

namespace TimeTravelAgency.Services;

public class DestinationService
{
    private readonly List<Destination> _destinations = new()
    {
        new Destination
        {
            Id = 1,
            Name = "Paris 1889",
            Era = "Belle Époque",
            ShortDescription = "Exposition Universelle & Tour Eiffel.",
            LongDescription = "Vivez l'inauguration de la Tour Eiffel et l'effervescence artistique du Paris de 1889.",
            ImageUrl = "/images/paris1889.jpg",
            PriceFrom = 4900
        },
        new Destination
        {
            Id = 2,
            Name = "Crétacé",
            Era = "-65 Millions d'années",
            ShortDescription = "Immersion préhistorique sécurisée.",
            LongDescription = "Observez les dinosaures dans leur habitat naturel grâce à nos protocoles de sécurité avancés.",
            ImageUrl = "/images/cretaceous.jpg",
            PriceFrom = 12000
        },
        new Destination
        {
            Id = 3,
            Name = "Florence 1504",
            Era = "Renaissance",
            ShortDescription = "L'âge d'or artistique italien.",
            LongDescription = "Découvrez Florence au sommet de la Renaissance et rencontrez les plus grands artistes.",
            ImageUrl = "/images/florence1504.jpg",
            PriceFrom = 5200
        }
    };

    public List<Destination> GetAll() => _destinations;
    public Destination? GetById(int id) => _destinations.FirstOrDefault(d => d.Id == id);
}
