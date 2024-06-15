﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
		public void Add(TEntity entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(TEntity entity)
		{
			throw new NotImplementedException();
		}

		public TEntity Get(Expression<Func<TEntity, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public void Update(TEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}
