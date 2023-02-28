using System.ComponentModel.DataAnnotations;

namespace ComunikimeTest.Domain.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        { 
        }

        [Key]
        public int Id { get; set; }
    }
}
