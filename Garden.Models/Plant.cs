namespace Garden.Models;

public class Plant
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? FullName { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
    
    public ICollection<GardenPlant>? GardenPlants { get; set; }
}