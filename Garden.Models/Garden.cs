namespace Garden.Models;

public class Garden : IBaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int UserId { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
    
    public User User { get; set; }
    public ICollection<GardenPlant> GardenPlants { get; set; }
}