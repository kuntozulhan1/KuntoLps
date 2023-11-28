namespace KuntoLps.Controllers
{
    public class Task2
    {
        public class ApplicationInfo
        {
            public string Path { get; set; }
            public string Name { get; set; }
        }

        public class ReturnMoreThanOneValue
        {
            /// <summary>
            /// We can call properties inside a class like this.
            /// </summary>
            public (string Path, string Name) GetApplicationInfo()
            {
                var application = new ApplicationInfo
                {
                    Path = "C:/apps/",
                    Name = "Shield.exe"
                };
                return (application.Path, application.Name);
            }
        }
    }
}
