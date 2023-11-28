namespace KuntoLps.Controllers
{
    public class Application
    {
        public Protected? _protected { get; set; }
    }
    public class Protected
    {
        public long shieldLastRun { get; set; }
    }
    public class Task1
    {
        /// <summary>
        ///In using the application?. it means that it will first check whether the application class has a null value or not. 
        ///If null, it will not enter the if statement logic. But if not null, it will proceed to check the _protected property
        /// </summary>
        public long ClearAndEasierCode()
        {
            var application = new Application();
            if (application?._protected != null)
            {
                return application._protected.shieldLastRun;
            }
            return 0;
        }
    }
}
