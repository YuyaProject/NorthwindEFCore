﻿using System;
using System.Collections.Generic;

namespace ODataCoreExample.Db.Entities
{
	public class Employee : Entity<int>
	{
		public virtual string LastName { get; set; }

		public virtual string FirstName { get; set; }

		public virtual string Title { get; set; }

		public virtual string TitleOfCourtesy { get; set; }

		public virtual DateTime? BirthDate { get; set; }

		public virtual DateTime? HireDate { get; set; }

		public virtual string Address { get; set; }

		public virtual string City { get; set; }

		public virtual string Region { get; set; }

		public virtual string PostalCode { get; set; }

		public virtual string Country { get; set; }

		public virtual string HomePhone { get; set; }

		public virtual string Extension { get; set; }

		public virtual byte[] Photo { get; set; }

		public virtual string Notes { get; set; }

		public virtual int? ReportsToId { get; set; }
		public virtual Employee ReportsTo { get; set; }

		public virtual string PhotoPath { get; set; }

		public virtual List<Employee> Employees { get; set; } = new List<Employee>();
		public virtual List<EmployeeTerritory> EmployeeTerritories { get; set; } = new List<EmployeeTerritory>();
		public virtual List<Order> Orders { get; set; } = new List<Order>();
	}
}