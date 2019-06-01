﻿using System.Collections.Generic;

namespace ODataCoreExample.Db.Entities
{
	public class Shipper : Entity<int>
	{
		public virtual string CompanyName { get; set; }
		public virtual string Phone { get; set; }
		public virtual List<Order> Orders { get; set; } = new List<Order>();
	}
}