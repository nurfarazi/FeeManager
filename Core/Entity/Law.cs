using System.ComponentModel.DataAnnotations.Schema;
namespace Core.Entity;

public class Law :BaseEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string LawId { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
}