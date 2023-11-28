namespace KuntoLps.Controllers
{
    public class Task3
    {
        /// <summary>
        /// set private Laptop, and set public Os. Actually, i dont really understand what the question means. if i set Os as private,
        /// i cannot invoke the property on console.
        /// </summary>
        private class Laptop
        {
            public string Os { get; set; } // can be modified
            public Laptop(string os)
            {
                Os = os;
            }
        }
        public static void Main()
        {
            var laptop = new Laptop("macOs");
            Console.WriteLine(laptop.Os); // Laptop os: macOs
        }

    }
}
