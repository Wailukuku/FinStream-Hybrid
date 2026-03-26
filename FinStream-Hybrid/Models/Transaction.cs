using System.ComponentModel.DataAnnotations;

namespace FinStream_Hybrid.Models
{
    public class Transaction
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [Range(0.01, 1000000)]
        public decimal Amount { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        public string Category { get; set; } = "Général";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
