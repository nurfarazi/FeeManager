using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entity;

public class Fee : BaseEntity
{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string FeeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
}

