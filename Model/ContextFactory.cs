using Librirary;
using Microsoft.EntityFrameworkCore.Design;

namespace Libriary
{
	internal class ContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
	{
		public ApplicationContext CreateDbContext(string[] args) => new ApplicationContext(ApplicationContext.GetDb());
	}
}
