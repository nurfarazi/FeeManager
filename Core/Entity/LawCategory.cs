using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entity;

public class LawCategory : BaseEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string LawCategoryId { get; set; }

    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
}