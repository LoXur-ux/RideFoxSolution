namespace Librirary;

public class Context
{
	public static ApplicationContext Db { get; private set; }
	public static void AddDb(ApplicationContext context) => Db = context;

	public Context(ApplicationContext context)
	{
		Db = context;
	}
}
