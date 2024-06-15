using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.Concrete.EntityFramework
{
	public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
		where TEntity : class, new()
		where TContext : DbContext, new()
	{
	}
}
