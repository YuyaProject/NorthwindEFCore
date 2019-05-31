using System.ComponentModel.DataAnnotations;

namespace ODataCoreExample.Db.Entities
{
    public abstract class Entity<TKey>
    {
        [Key]
        [Required]
        public virtual TKey Id { get; set; }

    }
}
