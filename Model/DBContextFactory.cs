namespace Librirary;

internal class DBContextFactory
{
    private static ApplicationContext? applicationContext;
    public static ApplicationContext? ApplicationContext
    {
        get
        {
            return applicationContext ?? new ApplicationContext(ApplicationContext.GetDb());
        }
    }
}
