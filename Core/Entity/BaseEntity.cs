namespace Core.Entity;

public class BaseEntity
{
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime DeletedAt { get; set; }
    
    public bool IsDeleted { get; set; } = false;
    public bool IsActive { get; set; } = true;
    
    public string CreatedBy { get; set; }
    public string UpdatedBy { get; set; }
    public string DeletedBy { get; set; }
}