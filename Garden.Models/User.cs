using System.ComponentModel.DataAnnotations;

namespace Garden.Models;

public class User : IBaseEntity
{
    public int Id { get; set; }
    [MaxLength(50)]
    public string Forename { get; set; }
    [MaxLength(50)]
    public string Surname { get; set; }
    [MaxLength(250)]
    public string Email { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
    
    public ICollection<Garden>? Gardens { get; set; }
}