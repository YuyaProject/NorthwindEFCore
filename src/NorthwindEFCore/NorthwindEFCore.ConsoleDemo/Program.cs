using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace NorthwindEFCore.ConsoleDemo
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			var config = new DbContextOptionsBuilder<NorthwindDbContext>();
			config.UseSqlite("Data Source=NorthwindDB.sqlite");
			using (var northwindDbContext = new NorthwindDbContext(config.Options))
			{
				var categories = northwindDbContext.Categories.ToList();
			}
		}
	}
}