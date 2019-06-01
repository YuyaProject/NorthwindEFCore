using System.Collections.Generic;

namespace ODataCoreExample.Db.Entities
{
	public class Region : Entity<int>
	{
		public virtual string RegionDescription { get; set; }
		public virtual List<Territory> Territories { get; set; } = new List<Territory>();
	}
}