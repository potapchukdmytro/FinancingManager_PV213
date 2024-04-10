using System.ComponentModel.DataAnnotations.Schema;

namespace FinancingManager.Entities
{
    public class CostEntity : BaseEntity
    {

        public double Cost { get; set; }

        public required string Name { get; set; }

        public required string Currency { get; set; }

        public required string CostType { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public UserEntity? User { get; set; }
    }
}
