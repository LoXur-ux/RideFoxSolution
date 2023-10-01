namespace Librirary;

internal class DBContextFactory
{
	private static ApplicationContext? applicationContext;
	public static ApplicationContext? ApplicationContext => applicationContext ?? new ApplicationContext(ApplicationContext.GetDb());
}
