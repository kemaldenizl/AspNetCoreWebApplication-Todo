using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfTodoDal:EfEntityRepositoryBase<Todo, TodoContext>, ITodoDal
	{
	}
}
