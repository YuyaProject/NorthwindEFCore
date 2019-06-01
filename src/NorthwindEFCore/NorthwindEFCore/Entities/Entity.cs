using System.ComponentModel.DataAnnotations;

namespace NorthwindEFCore.Entities
{
	public abstract class Entity<TKey> : IEntity
	{
		[Key]
		[Required]
		public virtual TKey Id { get; set; }
	}
}