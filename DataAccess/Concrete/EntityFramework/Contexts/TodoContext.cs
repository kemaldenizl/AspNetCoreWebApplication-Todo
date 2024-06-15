using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
	public class TodoContext: DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"server=DESKTOP-3C9L670;database=db_todos; integrated security=SSPI; TrustServerCertificate=True;");
		}

		public DbSet<Todo> Todos { get; set; }
	}
}
