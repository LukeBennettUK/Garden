namespace Garden.Models;

public interface IBaseEntity
{
    int Id { get; set; }
    DateTime Created { get; set; }
    DateTime? Updated { get; set; }
}