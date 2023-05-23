namespace Garden.Models;

public class GardenPlant
{
    public int Id { get; set; }
    public int GardenId { get; set; }
    public int PlantId { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
    
    public Garden Garden { get; set; }
    public Plant Plant { get; set; }
}