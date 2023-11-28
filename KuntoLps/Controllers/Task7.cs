namespace KuntoLps.Controllers
{
    class Cache
    {
        private static readonly Dictionary<int, CachedData> _cache = new Dictionary<int, CachedData>();
        public static void Add(int key, object value, TimeSpan lifespan)
        {
            _cache.Add(key, new CachedData { Value = value, ExpirationDate = DateTime.Now + lifespan });
        }
        public static object? Get(int key)
        {
            if (!_cache.ContainsKey(key))
            {
                return null;
            }

            CachedData item = _cache[key];

            if (item.ExpirationDate < DateTime.Now)
            {
                _cache.Remove(key);
                return null;
            }
            return item.Value;
        }
        private sealed class CachedData
        {
            public object Value { get; set; }
            public DateTime ExpirationDate { get; set; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000000; i++)
            {
                Cache.Add(i, new object(), TimeSpan.FromMinutes(10));
            }
            Console.WriteLine("Cache populated");
            Console.ReadLine();
        }
    }
}
