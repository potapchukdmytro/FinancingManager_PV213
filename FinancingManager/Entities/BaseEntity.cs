using System.ComponentModel.DataAnnotations;

namespace FinancingManager.Entities
{
    public interface IBaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
    }

    public class BaseEntity : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
